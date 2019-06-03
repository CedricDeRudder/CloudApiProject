import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MovieserviceService {

  constructor(private http : HttpClient) { }

  getDataById(id: string = "550") {
    return this.http.get<MovieID>(`https://api.themoviedb.org/3/movie/${id}?api_key=79e9d7caeef3888dc9dcafe45f6720d2`)
  }

  getDataByPopularity(page: string = "1") {
    return this.http.get<Movie>(`https://api.themoviedb.org/3/discover/movie?page=${page}&api_key=79e9d7caeef3888dc9dcafe45f6720d2`)
  }

}


  export interface BelongsToCollection {
      id: number;
      name: string;
      poster_path: string;
      backdrop_path: string;
  }

  export interface Genre {
      id: number;
      name: string;
  }

  export interface ProductionCompany {
      id: number;
      logo_path: string;
      name: string;
      origin_country: string;
  }

  export interface ProductionCountry {
      iso_3166_1: string;
      name: string;
  }

  export interface SpokenLanguage {
      iso_639_1: string;
      name: string;
  }

  export interface MovieID {
      adult: boolean;
      backdrop_path: string;
      belongs_to_collection: BelongsToCollection;
      budget: number;
      genres: Genre[];
      homepage?: any;
      id: number;
      imdb_id: string;
      original_language: string;
      original_title: string;
      overview: string;
      popularity: number;
      poster_path: string;
      production_companies: ProductionCompany[];
      production_countries: ProductionCountry[];
      release_date: string;
      revenue: number;
      runtime: number;
      spoken_languages: SpokenLanguage[];
      status: string;
      tagline: string;
      title: string;
      video: boolean;
      vote_average: number;
      vote_count: number;
  }

  export interface Result {
    vote_count: number;
    id: number;
    video: boolean;
    vote_average: number;
    title: string;
    popularity: number;
    poster_path: string;
    original_language: string;
    original_title: string;
    genre_ids: number[];
    backdrop_path: string;
    adult: boolean;
    overview: string;
    release_date: string;
}

export interface Movie {
    page: number;
    total_results: number;
    total_pages: number;
    results: Result[];
}


