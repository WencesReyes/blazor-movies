function TestGetCurrentStaticValue() {
    DotNet.invokeMethodAsync("BlazorPeliculas.Client", "GetCurrentCount")
        .then(response => {
            console.log(`Count from js ${response}`);
        }).catch(error => {
            console.log(error);
        });
}

function TestGetCurrentValueFromInstance(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}