try {
    function block() {
      function foo() {
        console.log(x);
      }
      foo();
      let x = 3;
      foo();
    }
    block();
  } catch (e) {
    console.error("Example 1 error:", e.message);
  }