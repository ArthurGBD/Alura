const nomes = [
    "Nome 1","Nome 2","Nome 3","Nome 4",
    "Nome 5","Nome 6","Nome 7","Nome 8",
    "Nome 9","Nome 10","Nome 11","Nome 12",
    "Nome 13","Nome 14","Nome 15", "Nome 16",
];

const sala1 = nomes.slice(0, nomes.length/2);
const sala2 = nomes.slice(nomes.length/2);

console.log(`Alunos da sala 1: ${sala1}`);
console.log(`Alunos da sala 2: ${sala2}`);