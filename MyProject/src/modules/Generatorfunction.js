try {
    function gen(n) {
      return {
        [Symbol.iterator]() {
          let i = 0;
          return {
            next() {
              return {
                done: i > n,
                value: i++
              };
            }
          };
        }
      };
    }
  
    for (let v of gen(3)) {
      console.log("Example 9:", v);
    }
  } catch (e) {
    console.error("Example 9 error:", e.message);
  }

  try {
    function gen(n: number): Iterable<number> {
      return {
        [Symbol.iterator](): Iterator<number> {
          let i = 0;
          return {
            next(): IteratorResult<number> {
              return {
                done: i > n,
                value: i++
              };
            }
          };
        }
      };
    }
  
    for (let v of gen(3)) {
      console.log("Example 9:", v);
    }
  } catch (e: any) {
    console.error("Example 9 error:", e.message);
  }
  