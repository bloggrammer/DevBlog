// Typewritter
const typedTextSpan = document.querySelector('.typed-text');
const cursorSpan = document.querySelector('.cursor');

const textArray = ['hard.', 'fun.', 'a journey.', 'LIFE!'];
const typingDelay = 200;
const erasingDelay = 100;
const newTextDelay = 2000; // Delay between current and next text
let textArrayIndex = 0;
let charIndex = 0;

function type() {
	if (charIndex < textArray[textArrayIndex].length) {
		if (!cursorSpan.classList.contains('typing'))
			cursorSpan.classList.add('typing');
		typedTextSpan.textContent +=
			textArray[textArrayIndex].charAt(charIndex);
		charIndex++;
		setTimeout(type, typingDelay);
	} else {
		cursorSpan.classList.remove('typing');
		setTimeout(erase, newTextDelay);
	}
}

function erase() {
	if (charIndex > 0) {
		if (!cursorSpan.classList.contains('typing'))
			cursorSpan.classList.add('typing');
		typedTextSpan.textContent = textArray[textArrayIndex].substring(
			0,
			charIndex - 1
		);
		charIndex--;
		setTimeout(erase, erasingDelay);
	} else {
		cursorSpan.classList.remove('typing');
		textArrayIndex++;
		if (textArrayIndex >= textArray.length) textArrayIndex = 0;
		setTimeout(type, typingDelay + 1100);
	}
}

document.addEventListener('DOMContentLoaded', function () {
	// On DOM Load initiate the effect
	if (textArray.length) setTimeout(type, newTextDelay + 250);
});
// Typewritter
let topBtn = document.getElementById('top-btn');

topBtn.addEventListener('click', () => {
	window.scrollTo({ top: 0, left: 0, behavior: 'smooth' });
});
window.addEventListener('scroll', () => {
	window.scrollY > 500
		? (topBtn.style.opacity = 1)
		: (topBtn.style.opacity = 0);
});
document.getElementById('year').innerText = new Date().getFullYear();
