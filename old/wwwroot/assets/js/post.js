function openPopupWindow(url, win) {
	const w = 700;
	const h = 600;
	const y = win.top.outerHeight / 2 + win.top.screenY - h / 2;
	const x = win.top.outerWidth / 2 + win.top.screenX - w / 2;
	return win.open(
		url,
		'popup',
		`toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=${w}, height=${h}, top=${y}, left=${x}`
	);
}

document.getElementById('ca-selector').addEventListener('change', (e) => {
	switch (e.target.value) {
		case '2':
			location.href = 'blog.html';
			console.log(e.target.value);
			break;
		case '3':
			location.href = 'articles.html';
			break;
		case '4':
			location.href = 'tutorials.html';
			break;
		case '5':
			location.href = 'videos.html';
	}
});
function updateSelectedCategory(value) {
	document.getElementById('ca-selector')[value].selected = true;
}
