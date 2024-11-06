// Zugriff aus die Elemente
const Username = document.getElementById('username');
const UsernameCheckbox = document.getElementById('username-check')

// Event-Listener, um das Textfeld auf Änderungen zu überprüfen
Username.addEventListener('input', function() {
    //Überprüfen, ob das Textfeld nicht leer ist
    if (Username.ariaValueMax.trim() !== '') {
        UsernameCheckbox.disabled = false; // Checkbox aktivieren
    } else {
        UsernameCheckbox.disabled = true; // Checkbox deaktivieren, wenn das Textfeld leer ist
    }
});