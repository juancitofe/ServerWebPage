//Crear DOM para cerrar sesion en vez de acceder
function perfil() {
    let perfil = document.createElement("a"),
        contenido = document.createTextNode("Perfil");

    perfil.appendChild(contenido);

    perfil.setAttribute("id", "perfil");
    perfil.setAttribute("href", "perfil.aspx");

    let acceder = document.getElementById("acceder"),
        padre = acceder.parentNode;

    padre.replaceChild(perfil, acceder);
}

function panel() {
    let liPanel = document.createElement("li"),
        panel = document.createElement("a"),
        contenido = document.createTextNode("Panel Admin");

    panel.appendChild(contenido);

    panel.setAttribute("id", "Panel");
    panel.setAttribute("href", "panel.aspx");

    liPanel.appendChild(panel);

    let liAcceder = document.getElementById("liAcceder"),
        padre = liAcceder.parentNode;

    padre.insertBefore(liPanel, liAcceder);

}