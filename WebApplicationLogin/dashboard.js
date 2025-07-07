// Redirect to login if not authenticated
if (!sessionStorage.getItem('loggedInUser')) {
    location.href = 'index.html';
}

// Logout
document.getElementById('logoutBtn').addEventListener('click', () => {
    sessionStorage.removeItem('loggedInUser');
    location.href = 'index.html';
});

// Handle nav navigation
document.querySelectorAll('.nav-link').forEach(link => {
    link.addEventListener('click', e => {
        e.preventDefault();
        const section = e.target.getAttribute('data-section');
        document.querySelectorAll('.section').forEach(sec => sec.style.display = 'none');
        document.getElementById(section).style.display = 'block';

        if (section === 'profile') {
            const email = sessionStorage.getItem('loggedInUser');
            const users = JSON.parse(localStorage.getItem('users'));
            document.getElementById('profile').innerHTML = `<h4>Profile</h4><p><strong>Name:</strong> ${users[email].name}</p><p><strong>Email:</strong> ${email}</p>`;
        } else if (section === 'settings') {
            document.getElementById('settings').innerHTML = `<h4>Settings</h4><p>No settings available yet.</p>`;
        }
    });
});
