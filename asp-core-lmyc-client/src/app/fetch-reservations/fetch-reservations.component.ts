import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-reservations',
  templateUrl: './fetch-reservations.component.html'
})
export class FetchReservationsComponent {
  public reservations: Reservation[];
  public lmycUrl = "https://localhost:44346/";

  constructor(http: HttpClient) {
    http.get<Reservation[]>(this.lmycUrl + 'api/ReservationsAPI').subscribe(result => {
      this.reservations = result;
    }, error => console.error(error));
  }
}

interface Reservation {
  reservationId: number;
  reservedBy: string;
  startDate: string;
  endDate: string;
  user: string;
  userName: string;
  boatId: number;
  boat: string;
}
