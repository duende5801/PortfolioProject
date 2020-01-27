let xmlhttp = new XMLHttpRequest();
let url = "../data/data.json";

xmlhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        let myArr = JSON.parse(this.responseText);
        studentInfo(myArr);
    }
};
xmlhttp.open("GET", url, true);
xmlhttp.send();

//create an array
let students = [];
let studentsObj = [];

function studentInfo(info){
    console.log(info.students);
    for(let i = 0; i< info.students.length; i++){
        //create an object for each loop in array
        //fill the object array
        let nFO = {
            "firstName":info.students[i].firstName,
            "lastName":info.students[i].lastName,
            "nickName":info.students[i].nickname,
            "email":info.students[i].email,
            "slackName":info.students[i].slack,
            "contacts":info.students[i].contacts,
            "hobbies":info.students[i].hobbies
        };

        studentsObj.push(nFO);

        console.log("My student object array " + studentsObj[i].firstName);

    }
}

//Field elements
let firstName = document.getElementById('first');
let lastName = document.getElementById('last');
let nickName =  document.getElementById('nick');
let slackName = document.getElementById('slack');
let bestContact = document.getElementById('contact');
let hobbies = document.getElementById('hobbies');
let email = document.getElementById('email');


// Button elements
let prevBtn = document.getElementById("prevBtn");
let nextBtn = document.getElementById("nextBtn");
let firstBtn = document.getElementById("firstBtn");
let lastBtn = document.getElementById("lastBtn");
let btnRand = document.getElementById('btnRand');

//create an index counter
let count = 0;

//First and Last buttons and random buttons
firstBtn.addEventListener('click',function(e){
    firstName.value = studentsObj[0].firstName;
    lastName.value = studentsObj[0].lastName;
    nickName.value = studentsObj[0].nickName;
    slackName.value = studentsObj[0].slackName;
    bestContact.value = studentsObj[0].contacts;
    hobbies.value = studentsObj[0].hobbies;
    email.value = studentsObj[0].email;
})

lastBtn.addEventListener('click',function(e){
    firstName.value = studentsObj[22].firstName;
    lastName.value = studentsObj[22].lastName;
    nickName.value = studentsObj[22].nickName;
    slackName.value = studentsObj[22].slackName;
    bestContact.value = studentsObj[22].contacts;
    hobbies.value = studentsObj[22].hobbies;
    email.value = studentsObj[22].email;
})

btnRand.addEventListener('click', funcRandom);
function funcRandom(e){
    console.log(e);
    let ranNum = Math.floor(Math.random()*studentsObj.length);
    count = ranNum;
    cStudents();
};

//Previous Button
prevBtn.addEventListener('click', function (e) {
    count--;
    if (count < 0) {
        count = studentsObj.length - 1;
    }
    cStudents();

});

//Next Button
nextBtn.addEventListener('click', function (e) {
    console.log(count);
    count++;
    if (count > studentsObj.length - 1) {
        count = 0;
    }
    cStudents();

});

function cStudents() {
    //Check to see if count is out of bounds
    if (count >= 0 && count <= studentsObj.length) {
        firstName.value = studentsObj[count].firstName;
        lastName.value = studentsObj[count].lastName;
        nickName.value = studentsObj[count].nickName;
        slackName.value = studentsObj[count].slackName;
        bestContact.value = studentsObj[count].contacts;
        hobbies.value = studentsObj[count].hobbies;
        email.value = studentsObj[count].email;
        }
}