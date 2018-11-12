<?php


$tx1 = file_get_contents("/sys/class/net/eth0/statistics/tx_bytes");
$rx1 = file_get_contents("/sys/class/net/eth0/statistics/rx_bytes");
sleep(1);
$tx2 = file_get_contents("/sys/class/net/eth0/statistics/tx_bytes");
$rx2 = file_get_contents("/sys/class/net/eth0/statistics/rx_bytes");

$y = ($rx2-$rx1)*8;
echo $y;



?>