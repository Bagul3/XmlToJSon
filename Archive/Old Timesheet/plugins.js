
window.CallWebservice = function (data, data2, successCallback, failureCallback) {
    client.CallWebservice("<--" + successCallback + "-->", "<--" + failureCallback + "-->", "<--" + data + "-->", "<--" + data2 + "-->");
};

window.runSQL = function (data, successCallback, failureCallback) {
    client.runSQL("<--" + successCallback + "-->", "<--" + failureCallback + "-->", data);
};

window.saveFile = function (data, guid, successCallback, failureCallback) {
    client.saveFile("<--" + successCallback + "-->", "<--" + failureCallback + "-->", "<--" + data + "-->", guid);
};


window.printDoc = function (data, data2, successCallback, failureCallback) {
    client.printDoc("<--" + successCallback + "-->", "<--" + failureCallback + "-->", "<--" + data + "-->", "<--" + data2 + "-->");
};


window.printDocWithTable = function (data, data2, data3, successCallback, failureCallback) {
    client.printDocWithTable("<--" + successCallback + "-->", "<--" + failureCallback + "-->", "<--" + data + "-->", "<--" + data2 + "-->", "<--" + data3 + "-->");
};

window.getSystemValue = function (data, successCallback, failureCallback) {
    client.getSystemValue("<--" + successCallback + "-->", "<--" + failureCallback + "-->", "<--" + data + "-->");
};


window.closeHostWindow = function () {
    client.closeHostWindow("","","");
};



window.CheckQueue = function (successCallback, failureCallback) {
    cordova.exec(successCallback,
		      failureCallback,
		      'CheckQueue',
		      'check',
		      []);
};

window.BarcodeScanner = function (successCallback, failureCallback) {
    cordova.exec(successCallback,
		      failureCallback,
		      'BarcodeScanner',
		      'scan',
		      []);
}

window.SaveForm = function (data, guid, successCallback, failureCallback) {
    cordova.exec(successCallback,
		      failureCallback,
		      'SaveForm',
		      guid,
		      [data]);
}

window.showDateOrTime = function (action, successCallback, failureCallback) {
    cordova.exec(successCallback,
		      failureCallback,
		      'DatePickerPlugin',
		      action,
		      []);
}


window.Signature = function (successCallback, failureCallback) {

    cordova.exec(successCallback,
		      failureCallback,
		      'Signature',
		      'sign',
		      []);
}

