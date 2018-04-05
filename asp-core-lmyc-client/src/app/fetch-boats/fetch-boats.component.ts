import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-boats',
  templateUrl: './fetch-boats.component.html'
})
export class FetchBoatsComponent {
  public boats: Boat[];
  public lmycUrl = "https://localhost:44346/";

  constructor(http: HttpClient) {
    http.get<Boat[]>(this.lmycUrl + 'api/BoatsAPI').subscribe(result => {
      this.boats = result;
    }, error => console.error(error));
  }
}

interface Boat {
  boatId: number;
  boatName: string;
  picture: string;
  lengthInFeet: number;
  make: string;
  year: number;
  recordCreationDate: string;
  applicationUserId: string;
  applicationUser: string;
}
