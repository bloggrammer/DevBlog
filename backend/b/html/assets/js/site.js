(function () {
  document.getElementById('year').innerText = new Date().getFullYear();
  if (localStorage.getItem('theme') === 'dark') {
    toggleNightMode();
  }
  initScrollTop();
  initTooltip();
  toggleNightMode();
  addAppNavigation();
})();

function initScrollTop() {
  let topBtn = document.getElementById('top-btn');

  topBtn.addEventListener('click', () => {
    window.scrollTo({ top: 0, left: 0, behavior: 'smooth' });
  });
  window.addEventListener('scroll', () => {
    window.scrollY > 500
      ? (topBtn.style.opacity = 1)
      : (topBtn.style.opacity = 0);
  });
}
function initTooltip() {
  var tooltipTriggerList = [].slice.call(
    document.querySelectorAll('[data-bs-toggle="tooltip"]')
  );
  var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl);
  });
}

function toggleNightMode() {
  if (document.documentElement.getAttribute('data-bs-theme') == 'light') {
    document.documentElement.setAttribute('data-bs-theme', 'dark');
    document.getElementById('mode-switcher').classList.add('active');
    localStorage.setItem('theme', 'dark');
  } else {
    document.documentElement.setAttribute('data-bs-theme', 'light');
    document.getElementById('mode-switcher').classList.remove('active');
    localStorage.setItem('theme', '');
  }
}
function addAppNavigation() {
  // Toggle Nav Link
  var aObj = document.getElementsByClassName('nav-link');
  for (var i = 0; i < aObj.length; i++) {
    if (aObj[i].href === document.location.href) {
      aObj[i].classList.add('active');
    } else aObj[i].classList.remove('active');
  }
}
// Im
// kiss-to-up!

// let question = {
//   title: 'John',
//   url: 'Doe',
//   difficulty: 'easy',
//   status: 'done',
//   companies: ['a', 'b'].items[..].push(6),
//   frequency: 6,
//   id: 6,
// };
