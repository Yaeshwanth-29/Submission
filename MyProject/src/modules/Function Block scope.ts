try {
    function block(): void {
      function foo(): void {
        console.log(x);
      }
  
      // First call before declaration — will throw ReferenceError
      foo();
  
      let x: number = 3;
  
      // Second call after initialization — will log 3
      foo();
    }
  
    block();
  } catch (e: any) {
    console.error("Example 1 error:", e.message);
  }
  