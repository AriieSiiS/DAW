function close_me(e) {
    e.target.parentNode.style.display = 'none';
    enableForm(); 
}

function onchange_input_alt(e) {
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'First name*') validate_first_name(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'Last name*') validate_last_name(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'e-mail address*') validate_email(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'Repeat your e-email*') validate_repeat_email(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'User* (3 characters at least)') validate_user(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'Birth date* (dd/mm/yy)') validate_birth_date(e.target.value);
    if (e.target.parentNode.getElementsByTagName('span')[0].innerHTML == 'Telephone number* (+prefix)xxxxxxxxx') validate_tfn_number(e.target.value);
}

function enableForm() {
    let newUserElement = document.getElementById('new_user');
    newUserElement.style.pointerEvents = 'auto';
    newUserElement.style.filter = 'blur(0px)';
}

function disableForm() {
    let newUserElement = document.getElementById('new_user');
    newUserElement.style.pointerEvents = 'none';
    newUserElement.style.filter = 'blur(5px)';
    
}

function showErrorMessage(message) {
    var dialog = document.querySelector('.dialog');
    dialog.style.display = 'block';
    dialog.querySelector('span').innerText = message;
    disableForm(); 
}

const regexname = /^[a-zA-Z]{2,}$/; 
const regexemail = /^[a-z0-9]+[a-z0-9][*´/|º+-ç_]?[a-z0-9]*@([\a-z0-9-]+\.)+[\a-z]{2,4}$/;
const regexuser = /^[\w]{3}/;
const regexdate = /(0[1-9]|[12][0-9]|3[01])(\/|-)(0[1-9]|1[1,2])(\/|-)(19|20)\d{2}/;
const regexnumber = /^\(\+\d+\)\d{9}$/;

function validate_first_name(value) {
    let input = document.getElementById('name').nextElementSibling.nextElementSibling;
    if (regexname.test(value)) {
        console.log('Name is valid');
        input.style.color = '';  
        return true;
    } else {
        console.log('Invalid Name');
        showErrorMessage('Invalid Name');
        input.style.color = 'red';
        return false; 
    }
}

function validate_last_name(value) {
    let input = document.getElementById('surname').nextElementSibling.nextElementSibling;
    if (regexname.test(value)) {
        console.log('Last Name is valid');
        input.style.color = '';
        return true;
    } else {
        console.log('Invalid Name');
        input.style.color = 'red';
        showErrorMessage('Invalid Last Name');
        return false; 
    }
}

function validate_email(value) {
    let input = document.getElementById('e_mail').nextElementSibling.nextElementSibling;
    if (regexemail.test(value)) {
        console.log('Email is valid');
        input.style.color = '';
        return true;
    } else {
        console.log('Invalid email');
        input.style.color = 'red';
        showErrorMessage('Invalid email');
        return false; 
    }
}

function validate_repeat_email(value) {
    let input = document.getElementById('e_mail_conf').nextElementSibling.nextElementSibling;
    let emailInput = document.getElementById('e_mail').nextElementSibling.nextElementSibling;
    let emailValue = emailInput.value;

    if (value === emailValue) {
        console.log('Emails match');
        input.style.color = '';
        return true;
    } else {
        console.log('Emails do not match');
        input.style.color = 'red';
        showErrorMessage('Emails do not match');
        return false; 
    }
}

function validate_user(value) {
    let input = document.getElementById('user_name').nextElementSibling.nextElementSibling;
    if (regexuser.test(value)) {
        console.log('User match');
        input.style.color = '';
        return true;
    } else {
        console.log('User does not match');
        input.style.color = 'red';
        showErrorMessage('User does not match');
        return false; 
    }
}

function validate_birth_date(value) {
    let input = document.getElementById('birth_date').nextElementSibling.nextElementSibling;
    if (regexdate.test(value)) {
        console.log('Date is ok');
        input.style.color = '';
        return true;
    } else {
        console.log('Date is wrong');
        input.style.color = 'red';
        showErrorMessage('Date is wrong');
        return false; 
    }
}

function validate_tfn_number(value) {
    let input = document.getElementById('tfn_number').nextElementSibling.nextElementSibling;
    if (regexnumber.test(value)) {
        console.log('Number is ok');
        input.style.color = '';
        return true;
    } else {
        console.log('Number is wrong');
        input.style.color = 'red';
        showErrorMessage('Number is wrong');
        return false; 
    }
}

function validarFormulario() {
    let firstName = document.getElementById('name').nextElementSibling.nextElementSibling.value;
    let lastName = document.getElementById('surname').nextElementSibling.nextElementSibling.value;
    let email = document.getElementById('e_mail').nextElementSibling.nextElementSibling.value;
    let repeatEmail = document.getElementById('e_mail_conf').nextElementSibling.nextElementSibling.value;
    let userName = document.getElementById('user_name').nextElementSibling.nextElementSibling.value;
    let birthDate = document.getElementById('birth_date').nextElementSibling.nextElementSibling.value;
    let phoneNumber = document.getElementById('tfn_number').nextElementSibling.nextElementSibling.value;

    let isFirstNameValid = validate_first_name(firstName);
    let isLastNameValid = validate_last_name(lastName);
    let isEmailValid = validate_email(email);
    let isRepeatEmailValid = validate_repeat_email(repeatEmail);
    let isUserNameValid = validate_user(userName);
    let isBirthDateValid = validate_birth_date(birthDate);
    let isPhoneNumberValid = validate_tfn_number(phoneNumber);

    if (isFirstNameValid && isLastNameValid && isEmailValid && isRepeatEmailValid && isUserNameValid && isBirthDateValid && isPhoneNumberValid) {
        alert('Datos enviados correctamente al servidor');
    } else {
        alert('Por favor, completa todos los campos correctamente');
    }
}

