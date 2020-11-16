import axios from 'axios';

const moviesURL = "http://copafilmes.azurewebsites.net/api/filmes";

export const getMovies = async () => {
    const result = await axios.get(moviesURL);
    const testes = result.then(r => console.log(r));
}