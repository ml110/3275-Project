<?php
//include_once("include/connect.php");
$breadcrumb = "<ol class=\"breadcrumb\">
  <li class=\"index.php\">Home</li>
</ol>";

if(isset($_GET["cat"])) {
  $cat = $_GET["cat"];
  $catName;
  if(is_numeric($cat)) {
    if($cat == 1) { //All categories
      $catName = "All";
    }else if($cat == 2) { //GPU
      $catName = "GPU";
    }else if($cat == 3) { //Motherboard
      $catName = "Motherboard";
    }else if($cat == 4) { //CPU
      $catName = "CPU";
    }else if($cat == 5) { //RAM
      $catName = "RAM";
    }
  }
  $breadcrumb = "<ol class=\"breadcrumb\">
    <li><a href=\"index.php\">Home</a></li>
    <li><a href=\"?cat=1\">Categories</a></li>
    <li class=\"active\">".$catName."</li>
  </ol>";

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
    }

    $breadcrumb = "<ol class=\"breadcrumb\">
      <li><a href=\"index.php\">Home</a></li>
      <li class=\"active\">".$miscName."</li>
    </ol>";
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
      <a class="navbar-brand" href="index.php">CSIS 3275</a>
    </div>

    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">
        <li><a href="?misc=1">Orders</a></li>
        <li><a href="?misc=2">Contact</a></li>
        <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Categories <span class="caret"></span></a>
          <ul class="dropdown-menu">
            <li><a href="?cat=1">All</a></li>
            <li role="separator" class="divider"></li>
            <li><a href="?cat=2">GPU</a></li>
			<li><a href="?cat=3">Motherboard</a></li>
			<li><a href="?cat=4">CPU</a></li>
			<li><a href="?cat=5">RAM</a></li>
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

<?php echo $breadcrumb; ?>

  <div class="panel-body">
  </div>
</div>
</div>
  </body>
</html>
