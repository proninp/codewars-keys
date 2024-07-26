<?php

function problem($x)
{
    return is_numeric($x) ? $x * 50 + 6 : "Error";
}