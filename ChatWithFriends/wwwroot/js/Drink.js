function showHiddenDiv(ID) {
    document.getElementById('overlay').style.display = 'block';
    document.getElementById('hiddenDiv_' + ID).style.display = 'block';
}

function closeHiddenDiv() {
    document.getElementById('overlay').style.display = 'none';
    var hiddenDivs = document.querySelectorAll('.hiddendiv');
    hiddenDivs.forEach(function (div) {
        div.style.display = 'none';
    });
}

function validateForm() {
    var matSelected = false;
    var iceSelected = false;
    var sugarSelected = false;

    var matOptions = document.getElementsByName('teaMaterialName');
    for (var i = 0; i < matOptions.length; i++) {
        if (matOptions[i].checked) {
            matSelected = true;
            break;
        }
    }

    // 檢查是否選擇了任何冰塊選項
    var iceOptions = document.getElementsByName('IceName');
    for (var i = 0; i < iceOptions.length; i++) {
        if (iceOptions[i].checked) {
            iceSelected = true;
            break;
        }
    }

    // 檢查是否選擇了任何甜度選項
    var sugarOptions = document.getElementsByName('SugarName');
    for (var i = 0; i < sugarOptions.length; i++) {
        if (sugarOptions[i].checked) {
            sugarSelected = true;
            break;
        }
    }

    // 如果未選擇加料、冰塊或甜度，顯示提示並阻止表單提交
    if (!matSelected) {
        alert('加料必須選擇，你不想加也必須選~');
        return false; // 阻止表單提交
    }
    if (!iceSelected) {
        alert('冰塊必須選擇！');
        return false; // 阻止表單提交
    }
    if (!sugarSelected) {
        alert('甜度必須選擇！');
        return false; // 阻止表單提交
    }
    return true; // 允許表單提交
}