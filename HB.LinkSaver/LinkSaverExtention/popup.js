

document.addEventListener('DOMContentLoaded', function () {





    fetch('http://localhost:5003/home/customaction')
        .then(function (response) {
            if (!response.ok) {
                console.log("hata");
                throw new Error('fail ' + response.status);

            }
            return response.json();
        })
        .then(function (data) {


            var myContainer = document.getElementById('myContainer');
            data.forEach(function (category) {
                var option = document.createElement('span');
                option.classList.add("CategoryItem");
                option.textContent = category;

                myContainer.appendChild(option);
            });

        })
        .catch(function (error) {


            var container = document.getElementById('myContainer');

            var text = "You cannot use this Google extension when your desktop application is closed. Please open your application and refresh the page";
            var pItem = document.createElement('p');
            pItem.innerText = text;
            container.appendChild(pItem);

        });





    chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
        var activeTab = tabs[0];
        var url = activeTab.url;
        console.log(url);

        document.getElementById("datax").innerText = url;
    });




});

let selectedItems = [];



let btnSender = document.getElementById("mybtn");

btnSender.addEventListener('click', () => {



    // var encodedUrl = encodeURI(urlData);

    // console.log(encodedUrl);



    var desc = document.getElementById("description").value;
    var header = document.getElementById("header").value;
    var content = document.getElementById('datax').innerText;


    if (desc == "" || header == "" || selectedItems.length == 0) {

        alert("header , description cannot be empty and you have to select at least one category ");
        return;

    }
    var postData = {

        Header: header,
        Description: desc,
        Content: encodeURI(content),
        Categories: selectedItems

    };
    // var json = JSON.stringify(postData);


    var requestOptions = {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        },
        body: JSON.stringify(postData)
    };



    fetch('http://localhost:5003/home/savedata', requestOptions)
        .then(response => {
            // console.log(requestOptions);
            if (!response.ok) {
                throw new Error('HTTP error, status = ' + response.status);
            }
            return response.json();
        })
        .then(data => {
            console.log('success:', data);
            alert("Added!");
        })
        .catch(error => {

            alert("Already Exist");
            console.log('fail:', error);


        });



});


var customUl = document.getElementById("myCategoryList");


customUl.addEventListener("click", function (event) {
    const target = event.target;
    if (target.tagName === "LI") {
        const str = target.textContent;
        selectedItems = selectedItems.filter(item => item !== str);
        customUl.removeChild(target);


        mydiv.querySelectorAll('span').forEach(spans => {

            if (spans.textContent.trim() === str) {
                spans.classList.remove("selected");
                --selectedCounter;
            }

        });

    }
});



var selectedCounter = 0;
var mydiv = document.getElementById("myContainer");

mydiv.addEventListener('click', function (event) {




    var target = event.target;


    if (target.tagName == "SPAN") {
        var spanContent = target.textContent;

        var indexS = selectedItems.indexOf(spanContent);

        if (indexS == -1) {


            if (selectedCounter > 8) {
                console.log("max 8");
                return;
            }

            ++selectedCounter;
            selectedItems.push(spanContent);
            target.classList.add("selected");

            //liste'ye ekle 

            const li = document.createElement("li");
            li.textContent = spanContent;
            customUl.appendChild(li);

        }
        else {

            selectedItems.splice(indexS, 1);
            target.classList.remove("selected");
            --selectedCounter;


            customUl.querySelectorAll("li").forEach(lis => {
                if (lis.textContent.trim() === spanContent) {
                    lis.remove();
                }
            });



        }


    }

})

var searchInput = document.getElementById("CategorySearchBox");

searchInput.addEventListener('input', function () {
    var filterText = searchInput.value.toLocaleLowerCase('tr-TR');
    SearchCategory(filterText);
});


function SearchCategory(searchText) {

    var items = document.querySelectorAll('.CategoryItem');


    items.forEach(function (item) {
        var text = item.textContent.toLocaleLowerCase('tr-TR');
        if (text.includes(searchText)) {
            item.style.display = 'inline-block';
        } else {
            item.style.display = 'none';
        }
    });
    if (searchText === '') {
        items.forEach(function (item) {
            item.style.display = 'inline-block';
        });
    }
}

document.getElementById('clearBtn').addEventListener('click', function () {

    searchInput.value = "";
    SearchCategory("");

});


