<?php
/*$conn = mysqli_connect("173.180.133.176", "root", "superpassword", "hi-tec");
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connection_error);
}*/

include("include/connect.php");

/*function getContent($sql) {
  //$sql = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '1'";
  $conn = mysqli_connect("173.180.133.176", "root", "superpassword", "hi-tec");
  $result = $conn->query($sql);
  $counter = 0;
  $content = "<div id=\"row\">";
  if($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
      $counter++;
      $productname = $row["product_name"];
      $path = $row["product_img_path"];
      if(($counter % 4) == 0 ) {
        $content .= "</div>";
        $content .= "<div id=\"row\">";
      }
      $content .= "<div style=\"height:300px;width:200px;\" class=\"col-sm-6 col-md-4\"><div class=\"thumbnail\">";
      //$content .= "<div class=\"col-sm-6 col-md-4\"><div class=\"thumbnail\">";
      $content .= "<img src=\"images/".$path."\"></img>";
      $content .= "<div class=\"caption\"><h3>";
      if(strlen($productname) < 18) {
        $content .= $productname . "</h3><br/></div></div>";
      }else{
        $content .= $productname . "</h3></div></div>";
      }
      $content .= "</div>";
    }
    if(($counter % 4) != 0 ) {
      $content .= "</div>";
    }
  }else{
    $content = "<div class=\"alert alert-danger\" role=\"alert\">
  <span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\"></span>
  <span class=\"sr-only\">Error:</span>
  <strong>No Results Found</strong>
  </div>";
  }
  return $content;
}*/

function getContent($sql) {
  //$sql = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '1'";
  $conn = mysqli_connect("localhost", "root", "", "hi-tec");
  $result = $conn->query($sql);
  if($result->num_rows > 0) {
    $content = "<table class=\"table\">";
    while($row = $result->fetch_assoc()) {

      $productname = $row["product_name"];
      $path = $row["product_img_path"];
      $stock = $row["product_stock"];
      $manufacturer = $row["manufacturer_name"];
      $sku = $row["product_id"];

      $content .= "<tr>";
      //$content .= "<td width=\"20%\"><img height=\"50%\" width=\"50%\" src=\"images/".$path."\"></img></td>";
      $content .= "<td width=\"30%\"><img class=\"img-responsive\" src=\"images/".$path."\"></img></td>";
      $content .= "<td>";
      $content .= "<h4><strong><span style=\"color:blue;\">" . $productname . "</span></strong></h4>";
      $content .= "<strong>Manufacturer: </strong><span style=\"color:blue;\">" . $manufacturer . "</span><br/>";
      $content .= "<strong>SKU: </strong><span style=\"color:blue;\">" . $sku . "</span><br/>";
      if($stock > 0) {
        $content .= "<span style=\"font-size:16px;\" class=\"label label-success\">In Stock</span>";
        /*$content .= "<div style=\"width:50%;\" class=\"alert alert-success\">
    			<center><strong>In Stock</strong></center>
    		</div>";*/
      }else{
        $content .= "<span style=\"font-size:16px;\" class=\"label label-danger\">Out of Stock</span>";
        /*$content .= "<div class=\"alert alert-danger\">
    			<center><strong>Out of Stock</strong></center>
    		</div>";*/
      }
      $content .= "</td>";
      $content .= "</tr>";
    }
    $content .= "</table>";

  }else{
    $content = "<div class=\"alert alert-danger\" role=\"alert\">
  <span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\"></span>
  <span class=\"sr-only\">Error:</span>
  <strong>No Results Found</strong>
  </div>";
  }
  return $content;
}

$content = "";
$title = "HI-TEC Electronic Supply Ltd";

$breadcrumb = "<ol class=\"breadcrumb\">
  <li class=\"index.php\"><span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span> Home</li>
</ol>";

if(isset($_GET["cat"])) {
  $cat = $_GET["cat"];
  $catName = "";
  if(is_numeric($cat)) {
	if($cat == 1) {
	  $catName = "";
    $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id";
    $content = getContent($test);
    $title = "HI-TEC Electronic Supply Ltd | All Products";
    }else if($cat == 2) { // RAM
	  $catName = "RAM";
    $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '1'";
    $content = getContent($test);
    $title = "HI-TEC Electronic Supply Ltd | RAM";
    }else if($cat == 3) { //Motherboard
      $catName = "Motherboard";
      $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '2'";
      $content = getContent($test);
      $title = "HI-TEC Electronic Supply Ltd | Motherboard";
    }else if($cat == 4) { //GPU
	  $catName = "GPU";
    $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '3'";
    $content = getContent($test);
    $title = "HI-TEC Electronic Supply Ltd | GPU";
	}else if($cat == 5) { //CPU
      $catName = "CPU";
      $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '4'";
      $content = getContent($test);
      $title = "HI-TEC Electronic Supply Ltd | CPU";
    }else if($cat == 6) { //Storage
      $catName = "Storage";
      $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '5'";
      $content = getContent($test);
      $title = "HI-TEC Electronic Supply Ltd | Storage";
    }else if($cat == 7) { //PSU
      $catName = "PSU";
      $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '6'";
      $content = getContent($test);
      $title = "HI-TEC Electronic Supply Ltd | PSU";
    }else if($cat == 8) { //Displays
	  $catName = "Displays";
    $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '7'";
    $content = getContent($test);
    $title = "HI-TEC Electronic Supply Ltd | Displays";
	}else if($cat == 9) { //Keyboards
	  $catName = "Keyboards";
    $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '8'";
    $content = getContent($test);
    $title = "HI-TEC Electronic Supply Ltd | Keyboards";
	}else if($cat == 10) { //Mouse
	  $catName = "Mouse";
    $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '9'";
    $content = getContent($test);
    $title = "HI-TEC Electronic Supply Ltd | Mouse";
	}else if($cat == 11) { //Desktop
	  $catName = "Desktop";
    $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '10'";
    $content = getContent($test);
    $title = "HI-TEC Electronic Supply Ltd | Desktop";
	}else if($cat == 12) { //Accessories
	  $catName = "Accessories";
    $test = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where category_id = '11'";
    $content = getContent($test);
    $title = "HI-TEC Electronic Supply Ltd | Accessories";
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
		<li class=\"active\">Products</li>
		</ol>";
	}else if($cat > 1 && $cat < 13){
		$breadcrumb = "<ol class=\"breadcrumb\">
		<li><a href=\"index.php\"><span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span> Home</a></li>
		<li><a href=\"?cat=1\">Products</a></li>
		<li class=\"active\">".$catName."</li>
		</ol>";
	}
}else{
  //HOME
  //$content = "<h2>Welcome to Hi-Tec</h2>";
  //$content = "<div class=\"jumbotron\" style=\"background-image: url(images/warehouse2.png);\">
  $content = "<div class=\"row\">
      <div class=\"col-md-8\">
          <img class=\"img-responsive img-rounded\" src=\"images/warehouse3.png\" alt=\"\">
      </div>
      <!-- /.col-md-8 -->
      <div class=\"col-md-4\">
          <h1>HI-TEC Electronic Supply Ltd.</h1>
          <p>Hi-Tec is a supplier of electronics that delivers across the lower mainland. Our warehouse management system allows our employees to work at their highest potential.</p>
      </div>
      <!-- /.col-md-4 -->
  </div>";
}

if(isset($_GET["misc"])) {
  $misc = $_GET["misc"];
  $miscName;
  if(is_numeric($misc)) {
    if($misc == 1) { //ORDERS
      $miscName = "Orders";
      $content = "<div class=\"alert alert-info\" role=\"alert\">
  <span class=\"glyphicon glyphicon-info-sign\" aria-hidden=\"true\"></span>
  <strong>To place an order please call 604-584-8945, have your order information ready.</strong>
</div>";
      $title = "HI-TEC Electronic Supply Ltd | Orders";
      /*$content .= "<div class=\"panel panel-primary\">
  <div class=\"panel-heading\">Steps</div>
  <div class=\"panel-body\">";

      $content .= "<table class=\"table\"><tr class=\"info\"><td><strong>1.</strong> </td><td><strong>Have all of the product names of your order ready</strong></td></tr>";
      $content .= "<tr><td><strong>2.</strong> </td><td><strong>Call 604-584-8945</strong></td></tr>";
      $content .= "<tr class=\"info\"><td><strong>3.</strong> </td><td><strong>Recieve an estimation of cost, and estimated time of delivery</strong></td></tr>";
      $content .= "<tr><td><strong>4.</strong> </td><td><strong>Confirm your order</strong></td></tr>";
      $content .= "<tr class=\"info\"><td><strong>5.</strong> </td><td><strong> Confirm payment details</strong></td></tr>";
      $content .= "</table>";

      $content .= "</div></div>";*/

    }else if($misc == 2) { //CONTACT
      $miscName = "Contact";
      /*$content = "<div class=\"alert alert-info\" role=\"alert\">
  <span class=\"glyphicon glyphicon-info-sign\" aria-hidden=\"true\"></span>
  <strong>For general questions, please contact our toll free number: 1-888-5415-8971</strong>
</div>";*/
      $title = "HI-TEC Electronic Supply Ltd | Contact";
      $content = "<div class=\"panel panel-primary\">
        <div class=\"panel-heading\">Contact</div>
        <div class=\"panel-body\">";

      $content .= "<table class=\"table\"><tr class=\"info\"><td width=\"40%\"><img class=\"img-circle\" src=\"images/manveer.png\"></img></td><td><h4>Operations Manager</h4><strong>Manveer Sidhu</strong><br/><strong>778-256-2569</strong></br><strong>msidhu@hi-tec.com</strong></td></tr>";
      $content .= "<tr class=\"info\"><td width=\"40%\"><img class=\"img-circle\" src=\"images/matt.png\"></img></td><td><h4>Operations Manager</h4><strong>Manveer Sidhu</strong><br/><strong>778-256-2569</strong></br><strong>msidhu@hi-tec.com</strong></td></tr>";
      $content .= "</table>";

      $content .= "</div></div>";
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

if(isset($_GET["search"])) {
  $search = $_GET["search"];
    if (strlen($search) > 0) {
    $breadcrumb = "<ol class=\"breadcrumb\">
     <li><a href=\"index.php\"><span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span> Home</a></li>
     <li class=\"active\">Searching for \"".$search."\"</li>
    </ol>";
    $sql = "SELECT product_name,product_img_path,product_stock,manufacturer_name,product_id from product inner join manufacturer on product.manufacturer_id = manufacturer.manufacturer_id where product_name LIKE '%" . $search . "%'";
    $content = getContent($sql);
    $title = "HI-TEC Electronic Supply Ltd | " . $search;
  }else{
  /*$content = "<div class=\"alert alert-danger\" role=\"alert\">
<span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\"></span>
<span class=\"sr-only\">Error:</span>
<strong>Please enter something to search for</strong>
</div>";
    $breadcrumb = "<ol class=\"breadcrumb\">
     <li><a href=\"index.php\"><span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span> Home</a></li>
     <li class=\"active\">Searching for ...</li>
    </ol>";*/
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
    <title><?php echo $title; ?></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>
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
    <script>
    function validate() {
      var input = $("#srch").val();
      if(input.length == 0 )
      {
        alert("Please enter something to search");
      }else{
        window.location.href = "index.php?search=" + input;
      }
    }
    </script>
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
      <a class="navbar-brand" href="index.php"><span style="font-family:Trocchi;font-size:29px">HI-TEC</span></a> <!-- <span style="font-family:Trocchi;font-size:29px">HI-TEC</span> ---->
    </div>

    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">
        <li><a href="?misc=1">Orders</a></li>
        <li><a href="?misc=2">Contact</a></li>
        <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Products <span class="caret"></span></a>
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
      <div class="navbar-form navbar-left">
        <div class="input-group">
      <input type="text" id="srch" class="form-control" placeholder="GIGABYTE Radeon...">
      <span class="input-group-btn">
        <button type="submit" onclick="validate()" class="btn btn-default">
  <span class="glyphicon glyphicon-search" aria-hidden="true"></span>
</button>
      </span>
    </div>
  </div>
    </div>
  </div>
</nav>

<div class="panel panel-default">


<?php echo $breadcrumb; ?>

  <div class="panel-body">
  <?php echo $content; ?>

  </div>
</div>
</div>
  </body>
</html>
