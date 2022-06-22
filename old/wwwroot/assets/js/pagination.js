var page = 1;

function showPage(page) {
	document.querySelectorAll('.blog-list:not(#page' + page + ')');

	const hideEls = document.querySelectorAll(
		'.blog-list:not(#page' + page + ')'
	);
	hideEls.forEach((e) => {
		e.style.display = 'none';
	});
	const showEls = document.querySelectorAll('.blog-list#page' + page);
	showEls.forEach((e) => {
		e.style.display = '';
	});

	const aTags = document.querySelectorAll('.pagination a');

	aTags.forEach((a) => {
		if (a.innerText == page) {
			a.className = 'active';
		} else {
			a.className = '';
		}
	});
}

function prevPage() {
	if (page == 1) {
		page = document.querySelectorAll('.blog-list').length;
	} else {
		page--;
	}
	showPage(page);
}

function nextPage() {
	if (page == document.querySelectorAll('.blog-list').length) {
		page = 1;
	} else {
		page++;
	}
	showPage(page);
}
document.querySelector('.prev').addEventListener('click', prevPage);
document.querySelector('.next').addEventListener('click', nextPage);
window.onload = showPage(page);
