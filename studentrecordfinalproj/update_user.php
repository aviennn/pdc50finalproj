<?php
include 'db.php';

$data = json_decode(file_get_contents("php://input"));

$id = $data->id;
$idno = $data->idno;
$name = $data->name;
$gender = $data->gender;
$college = $data->college;
$course = $data->course;
$yearlevel = $data->yearlevel;
$password = $data->password;

$sql = "UPDATE tblstudents SET Idno='$idno', Name='$name', Gender='$gender', College='$college' 
, Course='$course', Yearlevel='$yearlevel', Password='$password' WHERE ID=$id";

if ($conn->query($sql) === TRUE) {
    echo json_encode(["message" => "User updated successfully"]);
} else {
    echo json_encode(["message" => "Error: " . $conn->error]);
}

$conn->close();
?>