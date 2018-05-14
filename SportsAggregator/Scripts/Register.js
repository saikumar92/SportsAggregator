function check() {
    if (document.getElementById('password').value.length >= 8) {
        document.getElementById('message1').style.color = 'green';
        document.getElementById('message1').innerHTML = 'Valid Password';
        if (document.getElementById('password').value ==
            document.getElementById('confirm_password').value) {
            document.getElementById('message').style.color = 'green';
            document.getElementById('message').innerHTML = 'Matching';
            document.getElementById('submit_btn').disabled = false;
        }
        else {
            document.getElementById('message').style.color = 'red';
            document.getElementById('message').innerHTML = 'Password is Not Matching,please enter same password as in above field';
            document.getElementById('submit_btn').disabled = true;
        }
    }
    else {
        document.getElementById('message1').style.color = 'red';
        document.getElementById('message1').innerHTML = 'Password should be atleast 8 characters';
        document.getElementById('submit_btn').disabled = true;
    }
}

function Clear() {
    document.getElementById('UserName').value = "";
    document.getElementById('errorMessage1').hidden=true;
    document.getElementById('password').value = "";
    document.getElementById('errorMessage2').hidden=true;
}

function Register_Clear() {
    document.getElementById('FirstName').value = "";
    document.getElementById('MiddleName').value = "";
    document.getElementById('LastName').value = "";
    document.getElementById('AddressLine1').value = "";
    document.getElementById('AddressLine2').value = "";
    document.getElementById('City').value = "";
    document.getElementById('State').value = "";
    document.getElementById('ZipCode').value = "";
    document.getElementById('Country').selectedIndex = 0;
    document.getElementById('Sports').selectedIndex = -1;
    document.getElementById('Email').value = "";
    document.getElementById('Username').value = "";
    document.getElementById('errormessage1').hidden = true;
    document.getElementById('password').value = "";
    document.getElementById('message1').hidden = true;
    document.getElementById('confirm_password').value = "";
    document.getElementById('message').hidden = true;
}
