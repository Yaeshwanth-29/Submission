
function reverse(value: string): string;
function reverse(value: number): number;
function reverse(value: number[]): number[];

function reverse(value: any): any {
  if (typeof value === "string") {
    
    return value.split("").reverse().join("");
  }

  if (typeof value === "number") {
    
    const reversed = value.toString().split("").reverse().join("");
    return parseInt(reversed, 10);
  }

  if (Array.isArray(value)) {
    
    return [...value].reverse(); 
  }

}

console.log(reverse("yaeshwanth"));       
console.log(reverse(120));          
console.log(reverse([1, 2, 3, 4, 5])); 
