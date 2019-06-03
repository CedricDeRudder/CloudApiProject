import { Component, OnInit } from '@angular/core';
import { Movie, MovieserviceService, MovieID } from '../movieservice.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  result: MovieID;
  result2: Movie;
  constructor(private svc: MovieserviceService) {
   }

  async ngOnInit() {
    this.result = await this.svc.getDataById();
    this.result2 = await this.svc.getDataByPopularity();
  }
}
