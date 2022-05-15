window.onload = (event) => {
    document.getElementById("darkSwitch").addEventListener('change', (event) => { changeTheme(); })

    var checked = JSON.parse(localStorage.getItem("darkMode"));
    document.getElementById("darkSwitch").checked = checked;
    changeTheme();
};


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
