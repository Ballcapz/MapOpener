function mapSelector() {
    if ((navigator.platform.indexOf('iPhone') != -1)
        || navigator.platform.indexOf('iPad') != -1
        || navigator.platform.indexOf('iPod') != -1) {
        window.open("maps://maps.google.com/maps?daddr=13,17&amp;ll=");
    } else {
        window.open("https://maps.google.com/maps?daddr=13,17&amp;ll=");
    }
}