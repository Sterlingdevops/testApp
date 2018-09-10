// JScript File
function printHTML(itm)
{
    var htm = document.getElementById(itm).innerHTML;
    var styl = "<style type='text/css'>* {font-family:Verdana;}</style>";
    newwin = window.open('../sync/printpage.htm','printwin');
    newwin.document.write(styl);
    newwin.document.write("<input type='button' value='PRINT' onclick='window.print()' /><br />");
    newwin.document.write(htm);
    newwin.document.close();
}


function closeInfo()
{
    $(".infoFalse").fadeOut(500);
    $(".infoTrue").fadeOut(500);
}

 function doNominate(itm)
 {
    location.href = 'nominate.aspx?award=' + itm;
 }
 
 function doVote(itm)
 {
    location.href = 'vote.aspx?award=' + itm;
 }
 
 function doResult(itm)
 {
    location.href = 'result.aspx?award=' + itm;
 }

  function lookupstaff()
  {
    var x = window.open ("/sync/stafflist.aspx","mywindow","status=1,scrollbars=1,width=600,height=400");  
  }
