<?php
//include_once("include/connect.php");
$breadcrumb = "<ol class=\"breadcrumb\">
  <li class=\"index.php\"><span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span> Home</li>
</ol>";
$content = "";

if(isset($_GET["cat"])) {
  $cat = $_GET["cat"];
  $catName;
  if(is_numeric($cat)) {
	if($cat == 1) {
	  $catName = "";
    }else if($cat == 2) { // RAM
	  $catName = "Ram";
    }else if($cat == 3) { //Motherboard
      $catName = "Motherboard";
    }else if($cat == 4) { //GPU
	  $catName = "GPU";
	}else if($cat == 5) { //CPU
      $catName = "CPU";
    }else if($cat == 6) { //Storage
      $catName = "Storage";
    }else if($cat == 7) { //PSU
      $catName = "PSU";
    }else if($cat == 8) { //Displays
	  $catName = "Displays";
	}else if($cat == 9) { //Keyboards
	  $catName = "Keyboards";
	}else if($cat == 10) { //Mice
	  $catName = "Mouse";
	}else if($cat == 11) { //Desktop
	  $catName = "Desktop";
	}else if($cat == 12) { //Accessories
	  $catName = "Accessories";
	}else {
	  //invalid category
	  $content = "<div class=\"alert alert-danger\" role=\"alert\">
  <span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\"></span>
  <span class=\"sr-only\">Error:</span>
  Not a valid category.
</div>";
	}
  }
	if($cat == 1) {
		$breadcrumb = "<ol class=\"breadcrumb\">
		<li><a href=\"index.php\"><span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span> Home</a></li>
		<li class=\"active\">Categories</li>
		</ol>";
	}else if($cat > 1 && $cat < 13){
		$breadcrumb = "<ol class=\"breadcrumb\">
		<li><a href=\"index.php\"><span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span> Home</a></li>
		<li><a href=\"?cat=1\">Categories</a></li>
		<li class=\"active\">".$catName."</li>
		</ol>";
	}
}else{
  //NO VALID CATEGORY
}

if(isset($_GET["misc"])) {
  $misc = $_GET["misc"];
  $miscName;
  if(is_numeric($misc)) {
    if($misc == 1) { //ORDERS
      $miscName = "Orders";
    }else if($misc == 2) { //CONTACT
      $miscName = "Contact";
    }else{
	   $content = "<div class=\"alert alert-danger\" role=\"alert\">
  <span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\"></span>
  <span class=\"sr-only\">Error:</span>
  Not a valid category.
</div>";
	}
	if($misc > 0 && $misc < 3) {
	   $breadcrumb = "<ol class=\"breadcrumb\">
      <li><a href=\"index.php\"><span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span> Home</a></li>
      <li class=\"active\">".$miscName."</li>
    </ol>";
	}
  }else{
    //NO VALID MISC
  }
}



?>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>test</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>
    <script src="js/manjot.js"></script>
    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
	<style>
	@font-face {
		font-family: Trocchi;
		src: url('fonts/Trocchi.otf');
	}
	</style>
  </head>
  <body>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
	<div class="container">
			<nav class="navbar navbar-default">
  <div class="container-fluid">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand" href="index.php"><span style="font-family:Trocchi;font-size:29px">Hi-Tec</span></a>
    </div>

    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">
        <li><a href="?misc=1">Orders</a></li>
        <li><a href="?misc=2">Contact</a></li>
        <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Categories <span class="caret"></span></a>
          <ul class="dropdown-menu">
            <li><a href="?cat=2">RAM</a></li>
            <li><a href="?cat=3">Motherboard</a></li>
			<li><a href="?cat=4">GPUs</a></li>
			<li><a href="?cat=5">CPUs</a></li>
			<li><a href="?cat=6">Storage</a></li>
			<li><a href="?cat=7">PSUs</a></li>
			<li><a href="?cat=8">Displays</a></li>
			<li><a href="?cat=9">Keyboards</a></li>
			<li><a href="?cat=10">Mouse</a></li>
			<li><a href="?cat=11">Desktop</a></li>
			<li><a href="?cat=12">Accessories</a></li>
          </ul>
        </li>
      </ul>
      <form class="navbar-form navbar-left">
        <div class="input-group">
      <input type="text" class="form-control" placeholder="GIGABYTE Radeon...">
      <span class="input-group-btn">
        <button type="button" class="btn btn-default">
  <span class="glyphicon glyphicon-search" aria-hidden="true"></span>
</button>
      </span>
    </div>
      </form>
    </div>
  </div>
</nav>

<div class="panel panel-default">
<!--- BREADCRUMB ///////////////////////////////////////////////
////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////
<ol id="brdCrmb" class="breadcrumb">
  <li><a href="index.php">Home</a></li>
  <li><a href="#">Categories</a></li>
  <li class="active">GPU</li>
</ol>

///////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////BREADCRUMB  -->

<?php echo $breadcrumb; ?>

  <div class="panel-body">
  <?php echo $content; ?>
  <!--
	<div class="row">
  IN STOCK///////////////////////////////////////////////
  ////////////////////////////////////////////////////////////
  ////////////////////////////////////////////////////////////
  <div class="col-sm-6 col-md-4">
    <div class="thumbnail">
      <img src="images/121125_2.jpg" alt="GPU">
      <div class="caption">
        <h4>GIGABYTE Radeon R9 380X Windforce 980MHZ 4GB 5.7GHZ GDDR5 DVI-D /I HDMI DisplayPort PCI-E Video Card</h4>
        <p>Price: $279.99</p>
		<div class="alert alert-success">
			<center><strong>In Stock</strong></center>
		</div>
      </div>
    </div>
  </div>
  ////////////////////////////////////////////////////////////
  ////////////////////////////////////////////////////////////
  ////////////////////////////////////////////////////IN STOCK


  OUT OF STOCK///////////////////////////////////////////
  ////////////////////////////////////////////////////////////
  ////////////////////////////////////////////////////////////
  <div class="col-sm-6 col-md-4">
    <div class="thumbnail">
      <img src="images/121125_2.jpg" alt="GPU">
      <div class="caption">
        <h4>GIGABYTE Radeon R9 380X Windforce 980MHZ 4GB 5.7GHZ GDDR5 DVI-D /I HDMI DisplayPort PCI-E Video Card</h4>
        <p>Price: $279.99</p>
		<div class="alert alert-danger">
			<center><strong>Out of Stock</strong></center>
		</div>
      </div>
    </div>
  </div>
  ////////////////////////////////////////////////////////////
  ////////////////////////////////////////////////////////////
  ////////////////////////////////////////////////OUT OF STOCK
</div>  -->
  </div>
</div>
</div>
  </body>
</html>
