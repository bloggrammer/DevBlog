document.getElementById('year').innerText = new Date().getFullYear();
let topBtn = document.getElementById('top-btn');

if (topBtn)
  topBtn.addEventListener('click', () => {
    window.scrollTo({ top: 0, left: 0, behavior: 'smooth' });
  });
window.addEventListener('scroll', () => {
  if (window.scrollY > 500 && topBtn) topBtn.style.opacity = 1;
  else if (topBtn) topBtn.style.opacity = 0;
});
if (localStorage.theme === 'dark' || (!('theme' in localStorage) && window.matchMedia('(prefers-color-scheme: dark)').matches)) {
  document.documentElement.setAttribute('data-theme', 'dark');
  document.getElementById('mode-switcher').classList.add('active');
}
function toggleNightMode() {
  if (document.documentElement.getAttribute('data-theme') == 'light') {
    document.documentElement.setAttribute('data-theme', 'dark');
    document.getElementById('mode-switcher').classList.add('active');
    localStorage.setItem('theme', 'dark');
  } else {
    document.documentElement.setAttribute('data-theme', 'light');
    document.getElementById('mode-switcher').classList.remove('active');
    localStorage.setItem('theme', '');
  }
}

function copyLinkShare() {
  navigator.clipboard.writeText(window.location.href).then(
    function () {
      alert('Copied: ' + window.location.href);
    },
    function () {
      alert('Failed to copy');
    }
  );
}
