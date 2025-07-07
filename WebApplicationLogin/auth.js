// Helper to get localStorage users object
function getUsers() {
    return JSON.parse(localStorage.getItem('users') || '{}');
}

function saveUsers(obj) {
    localStorage.setItem('users', JSON.stringify(obj));
}

// Register handler
document.getElementById('registerForm')?.addEventListener('submit', e => {
    e.preventDefault();
    const name = document.getElementById('regName').value.trim();
    const email = document.getElementById('regEmail').value.trim();
    const pwd = document.getElementById('regPassword').value;
    let users = getUsers();

    if (users[email]) {
        document.getElementById('regMessage').innerHTML = '<span class="text-danger">Email already registered</span>';
        return;
    }

    users[email] = { name, pwd };
    saveUsers(users);
    document.getElementById('regMessage').innerHTML = '<span class="text-success">Registered! Redirecting...</span>';
    setTimeout(() => location.href = 'index.html', 1500);
});

// Login handler
document.getElementById('loginForm')?.addEventListener('submit', e => {
    e.preventDefault();
    const email = document.getElementById('loginEmail').value.trim();
    const pwd = document.getElementById('loginPassword').value;
    let users = getUsers();

    if (users[email]?.pwd === pwd) {
        sessionStorage.setItem('loggedInUser', email);
        location.href = 'dashboard.html';
    } else {
        document.getElementById('loginMessage').innerHTML = '<span class="text-danger">Incorrect credentials</span>';
    }
});

// Forgot password
document.getElementById('forgotForm')?.addEventListener('submit', e => {
    e.preventDefault();
    const email = document.getElementById('forgotEmail').value.trim();
    let users = getUsers();

    if (users[email]) {
        document.getElementById('forgotMessage').innerHTML = '<span class="text-success">Your password: ' + users[email].pwd + '</span>';
    } else {
        document.getElementById('forgotMessage').innerHTML = '<span class="text-danger">Email not found</span>';
    }
});
