// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let mainContent;
let btnName = 'fieldbtn';
const btnIds = ['firstfieldbtn', 'secondfieldbtn', 'thirdfieldbtn'];
const fullness = [false, false, false];

window.onload = (event) => {
    document.getElementById("darkSwitch").addEventListener('change', (event) => { changeTheme(); })

    if (count !== undefined) {
        for (i = 0; i < count; i++) {
            fullness[i] = true;
        }
    }

    var checked = JSON.parse(localStorage.getItem("darkMode"));
    document.getElementById("darkSwitch").checked = checked;
    changeTheme();

    mainContent = document.getElementById("fields");
};

function addField() {
    if ('content' in document.createElement('template')) {
        let template = document.getElementById("field");
        let templateContent = template.content;

        let name = templateContent.getElementById("fieldname");
        let select = templateContent.getElementById("fieldselect");
        let btn = templateContent.getElementById("fieldbtn0");

        let nameLastId = name.id;
        let selectLastId = select.id;
        let btnLastId = btn.id;

        let i;
        for (i = 0; i < 3; i++) {
            if (!fullness[i]) {
                name.setAttribute('name', 'Fields[' + i + '].Name');
                select.setAttribute('name', 'Fields[' + i + '].Type');
                btn.id = btnName + i;
                fullness[i] = true;
                break;
            }
        }

        if (i == 3) {
            alert('Added the maximum possible number of fields');
        } else {
            mainContent.appendChild(templateContent.cloneNode(true));
            name.setAttribute('name', nameLastId);
            select.setAttribute('name', selectLastId);
            btn.id = btnLastId;
        }
    }
}

function RemoveTemplate(el) {
    let id = el.id.replace(btnName, '');
    fullness[id] = false;
    mainContent.removeChild(el.parentNode);
}



function changeTheme() {
    localStorage.setItem("darkMode", document.getElementById("darkSwitch").checked);
    document.querySelectorAll('link[rel=stylesheet].alternate').forEach(changeStylesheet);
}

function changeStylesheet(node) {
    if (JSON.parse(localStorage.getItem("darkMode"))) {
        node.disabled = true;
        localStorage.setItem("darkMode", 'true')
    } else {
        node.disabled = false;
        localStorage.setItem("darkMode", 'false')
    }
}
