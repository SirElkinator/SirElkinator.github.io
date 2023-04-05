function downloadFromUrl(url, filename) {
	const anchorElement = document.createElement('a');
	anchorElement.href = url;
	anchorElement.download = filename ?? '';
	anchorElement.click();
	anchorElement.remove();
}