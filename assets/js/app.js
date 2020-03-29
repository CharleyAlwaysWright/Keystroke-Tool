const app = require("electron").remote;
const dialog = app.dialog;
const fs = require("fs");
const Menu = app.Menu;
const ks = require("node-key-sender");

let RUNNING = false;

let FILE = "";

function LaunchEditor() {
	const BrowserWindow = app.BrowserWindow;
	const win = new BrowserWindow({
		height: 600,
		width: 1200
	});

	win.loadFile("src/editor.html");

	const Menutemplate = [
		{
			label: "File",
			submenu: [
				{
					label: "Save",
					click: function() {
						SaveFile();
					}
				},
				{
					label: "Load",
					click: function() {
						LoadFile();
					}
				},
				{
					label: "Quit",
					click: function() {
						win.close();
					}
				}
			]
		},
		{
			label: "Edit",
			submenu: [
				{
					label: "Copy",
					click: function() {}
				},
				{
					label: "Paste",
					click: function() {}
				},
				{
					label: "Cut",
					click: function() {}
				}
			]
		},
		{
			label: "Insert",
			submenu: [
				{
					label: "Delay",
					click: function() {}
				},
				{
					label: "Keyboard Shortcut",
					submenu: [
						{
							label: "Start",
							click: function() {}
						},
						{
							label: "End",
							click: function() {}
						},
						{
							label: "+",
							click: function() {}
						},
						{
							label: "CTRL",
							click: function() {}
						},
						{
							label: "ALT",
							click: function() {}
						},
						{
							label: "SHIFT",
							click: function() {}
						},
						{
							label: "DELETE",
							click: function() {}
						},
						{
							label: "Modifier (Win Key etc)",
							click: function() {}
						}
					]
				},
				{
					label: "Return",
					click: function() {}
				},
				{
					label: "Tab",
					click: function() {}
				},
				{
					label: "Delete",
					click: function() {}
				},
				{
					label: "Backspace",
					click: function() {}
				},
				{
					label: "Arrow Key",
					submenu: [
						{
							label: "Up arrow",
							click: function() {}
						},
						{
							label: "Down arrow",
							click: function() {}
						},
						{
							label: "Left arrow",
							click: function() {}
						},
						{
							label: "Right arrow",
							click: function() {}
						}
					]
				},
				{
					label: "Volume Control",
					submenu: [
						{
							label: "Volume Up",
							click: function() {}
						},
						{
							label: "Volume Down",
							click: function() {}
						}
					]
				}
			]
		},
		{
			label: "Help",
			submenu: [
				{
					label: "Offline docs",
					click: function() {
						LaunchDocs();
					}
				},
				{
					label: "Web docs",
					click: function() {}
				}
			]
		}
	];

	const menu = Menu.buildFromTemplate(Menutemplate);

	win.setMenu(menu);
}

function LaunchDocs() {
	const BrowserWindow = app.BrowserWindow;
	const win = new BrowserWindow({
		height: 700,
		width: 1400
	});

	win.removeMenu();

	win.loadFile("src/docs.html");
}

function Run() {
	let delay = Number(document.getElementById("StartDelay").value);

	setTimeout(() => {
		//              KEYCODES
		//
		////////////////////////////////////////
		//
		// \R           =   Return
		// \T           =   Tab
		// \DEL         =   Delete
		// \B           =   Backspace
		// \UP          =   Up arrow
		// \DOWN        =   Down arrow
		// \LEFT        =   Left arrow
		// \RIGHT       =   Right arrow
		// \VU          =   Volume Up
		// \VD          =   Volume Down
		//
		////////////////////////////////////////

		RUNNING = true;

		while (RUNNING === true) {
			const Cmds = Load();

			Cmds.forEach(cmd => {
				if (cmd.startsWith("\\")) {
					// type(cmd.substring(1))
				} else if (cmd.startsWith("\\D")) {
					const delay = Number(cmd.substring(1));
					setTimeout(() => {}, delay);
				} else {
					switch (cmd) {
						case "\\R":
							ks.sendKey("enter");
							break;

						case "\\T":
							ks.sendKey("tab");
							break;

						case "\\DEL":
							ks.sendKey("delete");
							break;

						case "\\B":
							ks.sendKey("back_space");
							break;

						case "\\UP":
							ks.sendKey("up");
							break;

						case "\\DOWN":
							ks.sendKey("down");
							break;

						case "\\LEFT":
							ks.sendKey("left");
							break;

						case "\\RIGHT":
							ks.sendKey("right");
							break;

						case "\\VU":
							break;

						case "\\VD":
							break;

						default:
							ks.sendText(cmd + " ");
							break;
					}
				}
			});
		}
	}, delay);
}

function Stop() {
	RUNNING = false;
}

function LoadFile() {
	dialog
		.showOpenDialog({
			title: "Open Script",
			buttonLabel: "Load Script",
			properties: ["openFile"]
		})
		.then(result => {
			if (result.filePaths === undefined) return;

			let fileName = result.filePaths[0].split("/");
			fileName = fileName[fileName.length - 1];

			fs.readFile(result.filePaths[0], "utf-8", (err, data) => {
				if (err) {
					alert(`An error ocurred reading the file :${err}`);
					return;
				}

				FILE = data;
				SetStatus(`Loaded: ${fileName}`);
				Store();
			});
		});
}

function SaveFile() {
	dialog
		.showSaveDialog({
			title: "Save Script",
			buttonLabel: "Save Script"
		})
		.then(result => {
			if (result.filePath === undefined) return;

			console.log(result);

			let fileName = result.filePath.split("/");
			fileName = fileName[fileName.length - 1];

			// fs.readFile(result.filePaths[0], "utf-8", (err, data) => {
			//     if(err){alert(`An error ocurred reading the file :${err}`); return}

			//     FILE = data;

			SetStatus(`Saved: ${fileName}`);
			// })
		});
}

function SetStatus(msg) {
	const FileLoadedElement = document.querySelector(".FileLoaded");
	FileLoadedElement.textContent = msg;
}

function Store() {
	document.querySelector(".fileContents").textContent = FILE;
}

function Load() {
	FILE = document.querySelector(".fileContents").textContent;

	return FILE.split(" ");
}

function sleep(ms) {
	return new Promise(resolve => {
		setTimeout(resolve, ms);
	});
}
