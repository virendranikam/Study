var myData = {
    Name: 'Virendra',
    lastName: 'Nikam',
    init: function () {
         
        UpdateData();
    }

};
function apicall() {
    // print first 10 numbers using for loop 
    //for (var i = 0; i < 10; i++) {
    //    console.log(i);
    //}

};

function UpdateData() {
    
    // call to update database api 
    $.ajax({
        url: 'Wheather/UpdateDataBase',
        type: 'GET',
        success: function (data) {
            console.log(data);
        }
    });

    
}
 
 


