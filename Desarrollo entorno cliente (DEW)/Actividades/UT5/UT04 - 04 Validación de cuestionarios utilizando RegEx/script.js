function close_me(e) { e.target.parentNode.style.display = 'none'; }

function onchange_input_alt(e) {
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'First name*') validate_first_name(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'Last name*') validate_last_name(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'e-mail address*') validate_email(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'Repeat your e-email*') validate_repeat_email(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'User* (3 characters at least)') validate_user(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'Birth date* (dd/mm/yy)') validate_birth_date(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'Telephone number* (+prefix)xxxxxxxxx') validate_tfn_number(e.target.value);
}

const regexname = /^[a-zA-Z]{2,}$/; //validación para nombre

//nombre
function validate_first_name(value) {
    if (regexname.test(value)) {
        console.log("First name is valid");
    } else {
        console.log("Invalid first name");
    }
}
//apellido
function validate_last_name(value) {
    if (regexname.test(value)) {
        console.log("Last name is valid");
    } else {
        console.log("Invalid last name");
    }
}
//email
function validate_email(value) {
    if (regexname.test(value)) {
        console.log("Email is valid");
    } else {
        console.log("Invalid email");
    }
}
//confirmacion email 