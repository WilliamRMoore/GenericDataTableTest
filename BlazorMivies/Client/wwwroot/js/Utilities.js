function my_function(message) {
    console.log("From utilities " + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMivies.Client", "GetCurrentCount")
        .then(result => {
            console.log("Count from JS " + result);
        });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");//tells the dotnet helper the name of the class
}