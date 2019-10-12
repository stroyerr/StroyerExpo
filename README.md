<html>
<script>
function click(){
	invert(link);
}

function invert(a){
	if (document.getElementById(a).style.display=="none"){
		document.getElementById(a).style.display="inline-block";
	}else{
		document.getElementById(a).style.display="none";	
		}
}
</script>
<h1>StroyerExpo</h1>
<h3>Small game I'm making to learn unity.</h3>
<input value="my page" onClick="click()" type="button">
<a href="www.github.com/Stroyerr" id="link" style="display:none;">My page</a>
</html>
