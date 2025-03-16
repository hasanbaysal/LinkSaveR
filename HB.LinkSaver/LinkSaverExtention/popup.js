//github.com/hasanbaysal/LinkSaveR

let allCategories = [];
let selectedItems = [];
document.addEventListener('DOMContentLoaded', function () {

    fetch('http://localhost:5003/home/GetCategories')
        .then(function (response) {
            if (!response.ok) {
                console.log("hata");
                throw new Error('fail ' + response.status);
            }
            return response.json();
        })
        .then(function (data) {
            allCategories = data;
            //all
            firstItem = allCategories[0];
            var myContainer = document.getElementById('myContainer');

            firstItem.SubCategories.forEach(function (category) {
                var option = document.createElement('span');
                option.classList.add("CategoryItem");
                option.textContent = category;
                myContainer.appendChild(option);
            });

            const comboBox = document.getElementById('categoryGroup');
            allCategories.forEach(ct => {
                const option = document.createElement('option');
                option.value = ct.CategorGroupName;
                option.textContent = ct.CategorGroupName;
                comboBox.appendChild(option);
            });



        })
        .catch(function (error) {
            var container = document.getElementById('myContainer');
            var text = "You cannot use this Google extension when your desktop application is closed. Please open your application and than go settings page. pls click on activate the server (if it is deactive) ";
            var pItem = document.createElement('p');
            pItem.style.color = 'white';
            pItem.innerText = text;
            container.appendChild(pItem);

        });

    if (chrome && chrome.tabs) {
        try {
            chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
                if (tabs && tabs[0]) {
                    var activeTab = tabs[0];
                    var url = activeTab.url;
                    console.log("URL:", url);
                    document.getElementById("datax").innerText = url;
                } else {
                    document.getElementById("datax").innerText = "Aktif sekme bulunamadý";
                    console.error("Aktif sekme bulunamadý");
                }
            });
        } catch (error) {
            document.getElementById("datax").innerText = "Hata: " + error.message;
            console.error("Hata:", error);
        }
    } else {
        document.getElementById("datax").innerText = "chrome.tabs API'si bulunamadý";
        console.error("chrome.tabs API'si bulunamadý");
    }

});



let btnSender = document.getElementById("mybtn");

btnSender.addEventListener('click', () => {



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


            if (selectedCounter >= 8) {
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




var selectElement = document.getElementById("categoryGroup");


selectElement.onchange = function () {
    var selectedValue = selectElement.value;
    var cdata = allCategories.find(c => c.CategorGroupName == selectedValue);

    var myContainer = document.getElementById('myContainer');
    myContainer.innerHTML = "";
    cdata.SubCategories.forEach(function (category) {
        var option = document.createElement('span');
        option.classList.add("CategoryItem");

        var indexS = selectedItems.indexOf(category);
        if (indexS != -1) {
            option.classList.add("selected");
        }

        option.textContent = category;
        myContainer.appendChild(option);
    });


}