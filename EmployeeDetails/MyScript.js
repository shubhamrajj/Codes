function CheckLength(source, argv) {
    var data = argv.Value;
    alert(data);

    if (data.length < 5) {
        argv.IsValid = false;
    }
    else {
        argv.IsValid = true;
    }
}