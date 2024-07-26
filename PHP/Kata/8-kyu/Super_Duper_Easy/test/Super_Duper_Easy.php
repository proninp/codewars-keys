<?php

// PHPUnit Test Examples:
// TODO: Replace examples and use TDD development by writing your own tests
class ProblemTest extends TestCase
{
    // test function names should start with "test"
    public function testProblem()
    {
        $this->assertEquals("Error", problem("a"));
        $this->assertEquals(56, problem(1));
        $this->assertEquals(256, problem(5));
        $this->assertEquals(6, problem(0));
        $this->assertEquals(66, problem(1.2));
        $this->assertEquals(156, problem(3));
        $this->assertEquals("Error", problem("RyanIsCool"));
        $this->assertEquals(-144, problem(-3));
    }

    private function sol($x)
    {
        if (is_string($x)) {
            return "Error";
        } else {
            return ($x * 50) + 6;
        }
    }

    private function getRandomString($n)
    {
        $characters = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
        $randomString = '';

        for ($i = 0; $i < $n; $i++) {
            $index = rand(0, strlen($characters) - 1);
            $randomString .= $characters[$index];
        }

        return $randomString;
    }

    public function testRandom()
    {
        for ($i = 0; $i < 100; $i++) {
            $n = rand(20, 100);
            if ($n < 5) {
                $s = $this->getRandomString(rand(5, 10));
                $this->assertEquals($this->sol($s), problem($s));
            } else {
                $this->assertEquals($this->sol($n), problem($n));
            }
        }
    }
}