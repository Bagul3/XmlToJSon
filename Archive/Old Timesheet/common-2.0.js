$.fn.serializeObject = function () {
    var o = {};
    var a = this.serializeArray();
    $.each(a, function () {
        if (o[this.name] !== undefined) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
};


$.fn.serializeObjectwithGrid = function () {
    var o = {};
    var a = this.serializeArray();
    $.each(a, function () {
        if (o[this.name] !== undefined) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });

    var grid = "#list486";
    if (grid != null) {
        o["grid"] = JSON.parse(getUserData(grid));
    }
    return o;
};




$.fn.scrollMinimal = function () {


    var cTop = 0;
    if (this.offset() != null) {
        cTop = this.offset().top;

    }
    var winHeight = window.innerHeight / 2;
    var cHeight = this.outerHeight(true);
    var windowTop = $(window).scrollTop();
    var visibleHeight = $(window).height();


    $(window).scrollTop(cTop - visibleHeight + (cHeight + winHeight));

};



//take single hide expresion and evaluate
function checkField(exp) {
   
    var expstring = exp;
    var arrHide = expstring.split('=');
    var arrSectionHide = expstring.split('#');
    var hideoperator, hidename, hidesection;
    if (arrSectionHide.length > 1)
    {
        hidesection = arrSectionHide[0];
        arrHide = arrSectionHide[1].split('=');
    }

    if (arrHide.length > 1) {

        if (arrHide[0].substring(arrHide[0].length - 1) == "!")
        {
            hidename = arrHide[0].substring(0, arrHide[0].length - 1);
            hideoperator = "!=";
        }
        else
        {
            hidename = arrHide[0];
            hideoperator = "=";
        }
        hidevalue = arrHide[1];
    }


    var rtn;
    if (hidevalue.indexOf("regex:") > -1) {
        var re = new RegExp(hidevalue.replaceAll("regex:", ""));
        if (hideoperator == "=") {
            if (re.test(getValue(hidename))) {
                rtn = true;
            }
            else {
                rtn = false;
            }
        }
        else {
            if (!re.test(getValue(hidename))) {
                rtn = true;
            }
            else {
                rtn = false;
            }
        }
    }
    else {

        if (hideoperator == "=") {

            if (getValue(hidename) == hidevalue) {
                rtn = true;
            } else {
                rtn = false;
            }
        }
        else {
            if (getValue(hidename) != hidevalue) {
                rtn = true;
            } else {
                rtn = false;
            }
        }
    }

    if (getValue(hidename) == undefined) rtn = true;
 
    //alert(hidename + ':' + getValue(hidename) + ' ' + hideoperator+ ' '+ hidevalue + ' so hide= ' + rtn)
    return rtn;
}






function runHide(field, sectionName) {

    var fieldName = field.name;
    var showFieldName = "";
    //find all fields which are affect by this field
    for (var i = 0; i < fieldObj.fields.length - 1; i++) {
        if (fieldObj.fields[i].hidesection == sectionName && fieldObj.fields[i].hidename.replaceAll('?', '') == fieldName ) {

            if (showFieldName != fieldObj.fields[i].name.replaceAll(' ', '_')) {
            
                var hideField = false;
                var expression = fieldObj.fields[i].hideexp;

                var arrAND = expression.split('+');
                for (var a = 0; a < arrAND.length; a++) {

                    var arrOR = arrAND[a].split('|');
                    if (arrOR.length > 1) {

                        for (var o = 0; o < arrOR.length; o++) {
                            if (o == 0) {
                                hideField = checkField(arrOR[o]);
                            } else { hideField = hideField | checkField(arrOR[o]); }
                        }
                    }
                    else {

                        if (a == 0) {
                            hideField = checkField(arrAND[a]);
                        } else { hideField = hideField & checkField(arrAND[a]); }

                    }
                }

                showFieldName = fieldObj.fields[i].name;
                
                if (!Boolean(hideField)) {
                    $("#p_" + showFieldName.replaceAll(' ', '_')).css("display", "block");
                }
                else {
                    clearValue(showFieldName);
                    $("#p_" + showFieldName.replaceAll(' ', '_')).css("display", "none");
                   
                }
            }
        }
   }

   }



   //clear values after hidden
   function clearValue(name) {
       if ($("input[name='" + name.replaceAll("?", "") + "']").is(":radio")) {
           $("input[name='" + name.replaceAll("?", "") + "']").removeAttr("checked");
           $("#ul_" + name.replaceAll(" ", "_") + "").find("li").removeClass("active-btn-pink");
       }
       else {
           $("#" + name.replaceAll(" ", "_")).val("");
       }
   }



//will only work with single fields only
function runHideOld(field, sectionName) {

    var fieldName = field.name;

    for (var i = 0; i < fieldObj.fields.length - 1; i++) {
        if (fieldObj.fields[i].hidesection == sectionName && fieldObj.fields[i].hidename.replaceAll('?', '') == fieldName) {
            if (fieldObj.fields[i].value.indexOf("regex:") > -1) {

                var re = new RegExp(fieldObj.fields[i].value.replaceAll("regex:", ""));
                if (fieldObj.fields[i].operator == "=") {
                    if (re.test(field.value)) {

                        $("#p_" + fieldObj.fields[i].name.replaceAll(' ', '_')).css("display", "none");
                    }
                    else {
                        $("#p_" + fieldObj.fields[i].name.replaceAll(' ', '_')).css("display", "block");
                    }
                }
                else {
                    if (!re.test(field.value)) {
                        $("#p_" + fieldObj.fields[i].name.replaceAll(' ', '_')).css("display", "none");
                    }
                    else {
                        $("#p_" + fieldObj.fields[i].name.replaceAll(' ', '_')).css("display", "block");
                    }
                }

            }
            else {

                if (fieldObj.fields[i].operator == "=") {
                    if (field.value == fieldObj.fields[i].value) {

                        $("#p_" + fieldObj.fields[i].name.replaceAll(' ', '_')).css("display", "none");
                    }
                    else {
                        $("#p_" + fieldObj.fields[i].name.replaceAll(' ', '_')).css("display", "block");
                    }
                }
                else {
                    if (field.value != fieldObj.fields[i].value) {
                        $("#p_" + fieldObj.fields[i].name.replaceAll(' ', '_')).css("display", "none");
                    }
                    else {
                        $("#p_" + fieldObj.fields[i].name.replaceAll(' ', '_')).css("display", "block");
                    }
                }
            }
        }
    }
}



function runHideSection(field, sectionName, value, operator) {
    var fieldName = field;
    var fieldValue = getValue(field);
    if (operator == "=") {
        if (fieldValue == value) {

            $("div[name='" + sectionName + "']").css("display", "none");
        }
        else {

            $("div[name='" + sectionName + "']").css("display", "block");
        }
    }
    else {
        if (fieldValue != value) {

            $("div[name='" + sectionName + "']").css("display", "none");
        }
        else {

            $("div[name='" + sectionName + "']").css("display", "block");
        }
    }
}


function getValue(name) {
    var value = "";
    if ($("input[name='" + name.replaceAll("?", "") + "']").is(":radio")) {
        value = $("input[name='" + name.replaceAll("?", "") + "']:checked").val();
    }
    else {
        value = $("#" + name.replaceAll(" ", "_")).val();
    }
    return value;
}






function isValidDate(s) {
    var bits = s.split('/');
    var d = new Date(bits[2] + '/' + bits[1] + '/' + bits[0]);
    return !!(d && (d.getMonth() + 1) == bits[1] && d.getDate() == Number(bits[0]));
}

function getAge(dateString) {
    var today = new Date();
    var birthDate = new Date(dateString);
    var age = today.getFullYear() - birthDate.getFullYear();
    var m = today.getMonth() - birthDate.getMonth();
    if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
        age--;
    }
    return age;
}

function setDate(field, min, max) {

    var dateString = $('#' + field + '_day').val().padLeft(2, '0') + "/" + $('#' + field + '_month').val().padLeft(2, '0') + "/" + $('#' + field + '_year').val();

    if (isValidDate(dateString)) {

        if (min != "") {
            if (parseInt(getAge(dateString)) < parseInt(min)) {
                alert('Minimum age is ' + min);
                return;
            }
        }

        if (max != "") {
            if (parseInt(getAge(dateString)) > parseInt(min)) {
                alert('Maximum age is ' + max);
                return;
            }
        }

        $('#' + field).val(dateString);
    }
    else {
        alert('Please enter a valid date');
        $('#' + field + '_day').val("");
        $('#' + field + '_month').val("");
        $('#' + field + '_year').val("");
        return;
    }

}





function isDateValid(field, min, max) {
    var dateString = $('#' + field + '_day').val().padLeft(2, '0') + "/" + $('#' + field + '_month').val().padLeft(2, '0') + "/" + $('#' + field + '_year').val();
    if (isValidDate(dateString)) {
        if (min != "") {
            if (parseInt(getAge(dateString)) < parseInt(min)) {
                return false;
            }
        }
        if (max != "") {
            if (parseInt(getAge(dateString)) > parseInt(max)) {
                return false;
            }
        }
        return true;
    }
    else {
        return false;
    }

}

function checkEmail(field) {
    if (!validateEmail($('#' + field).val())) {
        alert('Please enter a valid email address');
        $('#' + field).addClass("value-required");
    }
    else {
        $('#' + field).removeClass("value-required");
    }
}


function isEmailValid(field) {
    if (!validateEmail($('#' + field).val())) {
        return false;
    }
    else {
        return false;
    }
}



function validateEmail(email) {
    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}



function validateRegex(value, regextest) {
    var re = new RegExp(regextest);
    return re.test(value);
}



function checkRegex(field, regextest, alerttext) {
    if (!$('#' + field).hasClass('value-required')) {
        if (!validateRegex($('#' + field).val(), regextest)) {
            $('#' + field).addClass("value-required");
            navigator.notification.alert(alerttext, null, 'Validation Error', 'OK');
        }
        else {
            $('#' + field).removeClass("value-required");
        }
    }
}


function sign(fieldName) {
    window.Signature(function (result) {

        if (!result.cancelled) {

            var image = document.getElementById("img_" + fieldName);
            image.src = "data:image/jpeg;base64," + result.encodedImage;
            image.style.display = 'block';

            //save result

            var JSONImage = {};
            JSONImage["liveqsaveimage"] = result.encodedImage;

            window.SaveForm(JSONImage, "save",
        function (r) {
            $('#' + fieldName.replaceAll(" ", "_").replaceAll(".", "-")).val(r);
        },
        function (e) { alert(e); }
        );




        }
    }, function (error) {
        alert("Sign failed: " + error);
    }
           );
}

function takeImage(fieldName) {
    navigator.camera.getPicture(function (result) {
        var image = document.getElementById("img_" + fieldName);
        image.src = "data:image/jpeg;base64," + result;
        image.style.display = 'block';

        var JSONImage = {};
        JSONImage["liveqsaveimage"] = result;

        window.SaveForm(JSONImage, "save",
            function (r) {
                $('#' + fieldName.replaceAll(" ", "_").replaceAll(".", "-")).val(r);
                //                var hidden = document.getElementById(fieldName.replaceAll(" ", "-"));
                //                hidden.value = r;
            },
            function (e) { alert(e); }
            );

    }
          , function (error) {
              alert("Image failed: " + error);
          }, { quality: 50, destinationType: Camera.DestinationType.DATA_URL });
}



function barcode(fieldName) {

    window.BarcodeScanner(function (result) {

        $('#' + fieldName.replaceAll(" ", "_").replaceAll(".", "-")).val(result.text);

    }, function (error) {
        alert("Scanning failed: " + error);
    });

}

String.prototype.replaceAll = function (s1, s2) { return this.split(s1).join(s2) }


var saveguid = "save";



$(function () {
    //////////////////////////////////////////////////////////////////////
    ////SUBMIT////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////

    $("#submit").bind("touchstart", function () {


        runAllCanSaves();

        if (!canSave) {
            alert('Please complete all fields');
            return false;
        }

        var agree = confirm("Are you sure you want to finish?");
        if (!agree)
            return false;
        else {
            //run sql cmd on save
            saveSQL();

            window.SaveForm($('#liveqform').serializeObject(), saveguid, function (r) { window.location.href = "index.html"; }, function (e) { console.log(e) });
        }
    });
    //////////////////////////////////////////////////////////////////////
    ////SUBMIT////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////

    $("input").focus(function () {
        $(this).removeClass("value-required");
    });

    $("select").focus(function () {
        $(this).removeClass("value-required");
    });



    //get querystring
    var urlParams = {};
    (function () {
        var e,
            a = /\+/g,  // Regex for replacing addition symbol with a space
            r = /([^&=]+)=?([^&]*)/g,
            d = function (s) { return decodeURIComponent(s.replace(a, " ")); },
            q = window.location.search.substring(1);

        while (e = r.exec(q))
            urlParams[d(e[1])] = d(e[2]);
    })();



    $("#cancel-btn").bind("touchstart", function () {
        var agree = confirm("Are you sure you want to cancel?");
        if (agree)
            window.location = "index.html";
        else
            return false;
    });



    getUserData = function (grid) {

        var userData = "[";

        $(grid + " > tbody > tr.jqgrow").each(function (idx) {
            //$("tbody > tr.jqgrow").each(function (idx) {
            userData += "{";
          

                $(this).find("td").each(function (idx) {
                  try {
                    if (getColumnNameByIndex(idx, $(grid)) != " ") {
                        userData += '"' + getColumnNameByIndex(idx, $(grid)) + '": "' + getTextFromCell(this) + '", ';
                    }
                } catch (e) { }
                });
          
            userData = userData.substr(0, userData.length - 2);
            userData += "},";

        });
        if (userData == "[") {
            userData += "{} ";
        }
        userData = userData.substr(0, userData.length - 1) + "]";
        return userData;

    }



    getColumnNameByIndex = function (index, grid) {
        var cm = grid.jqGrid('getGridParam', 'colModel');
        return cm[index].name;

    }

    getColumnIndexByName = function (grid, columnName) {
        var cm = grid.jqGrid('getGridParam', 'colModel');
        for (var i = 0, l = cm.length; i < l; i++) {
            if (cm[i].name === columnName) {
                return i; // return the index
            }
        }
        return -1;
    }

    getTextFromCell = function (cellNode) {
        var myval = cellNode.childNodes[0].nodeName === "INPUT" ?
            cellNode.childNodes[0].value :
            cellNode.textContent || cellNode.innerText;
     
        return myval;
    }



});



//$(".list li > a").click(function radioButton(event) {
function radioButton(button) {
    // First disable the normal link click
    //event.preventDefault();

    // Remove all list and links active class.
    //$('.list > li, .list > li a').removeClass("active");

    //    $(button).parent().parent().find("li").removeClass("active-btn");
    //    $(button).parent().parent().find("li").removeClass("active-btn-bad");
    //    $(button).parent().parent().find("li").removeClass("active-btn-avg");

    $(button).parent().find("li").removeClass("active-btn-pink");
    $(button).addClass("active-btn-pink");
    $(button).parent().find("a").removeClass("radio-required");



    //$('#'+this.name).removeClass("active");
    //alert($('a.' + this.name.replace('link', 'class')).name);
    //        $('a[name="' + this.name + '"]').each(function () {
    //            $("#" + this.id).parent().removeClass("active");
    //        });
    // Grab the link clicks ID
    var id = button.id;

    var newselect = id.replace('link_', '');


    // Make newselect the option selected.
    $('#' + newselect).attr('checked', true);


}


Number.prototype.padLeft = function (width, char) {
    if (!char) {
        char = " ";
    }

    if (("" + this).length >= width) {
        return "" + this;
    }
    else {
        return arguments.callee.call(
      char + this,
      width,
      char
    );
    }
};



String.prototype.padLeft = function (width, char) {
    if (!char) {
        char = " ";
    }

    if (("" + this).length >= width) {
        return "" + this;
    }
    else {
        return arguments.callee.call(
      char + this,
      width,
      char
    );
    }
};



String.prototype.padRight = function (width, char) {
    if (!char) {
        char = " ";
    }

    if (("" + this).length >= width) {
        return "" + this;
    }
    else {
        return arguments.callee.call(
       this + char ,
      width,
      char
    );
    }
};





function cUpper(cObj) {
    cObj.value = cObj.value.toUpperCase();
}

