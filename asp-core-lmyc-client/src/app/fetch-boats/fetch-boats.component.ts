import { Component, OnInit } from '@angular/core';

import { AuthService } from '../auth.service';
import { BoatService } from '../boats.service';
import { Boat } from '../boats.service';

@Component({
  selector: 'app-fetch-boats',
  templateUrl: './fetch-boats.component.html',
  styleUrls: ['./fetch-boats.component.css'],
  providers: [BoatService]
})
export class FetchBoatsComponent implements OnInit {

  boats: Boat[];

  constructor(private boatService: BoatService) { }

  ngOnInit(): void {
    this.getBoats();
  }

  getBoats(): void {
    this.boatService.getBoats()
      .subscribe(boats => this.boats = boats, error => console.log(error));
  }
}

// import { Component, Inject, OnInit } from '@angular/core';
// import { HttpClient } from '@angular/common/http';
// import { AuthService } from '../auth.service';
// import { BoatService, Boat } from '../boats.service';

// @Component({
//   selector: 'app-fetch-boats',
//   templateUrl: './fetch-boats.component.html'
// })
// export class FetchBoatsComponent implements OnInit {

//   ngOnInit(): void {
//     console.log("Initializing Boats...");
//     this.boatService.GetBoats()
//     .then(r => {
//       console.log("Boats: " + r);
//       this.boats = r;
      
      
//     }).catch(r => {
//       alert("Error getting boats: " + r);
//     });
//   }

//   public boatService: BoatService;
//   public boats: Array<Boat> = [];
//   public lmycUrl = "https://localhost:44346/api/boatsapi/";

//   constructor(boatService: BoatService) {
//     this.boatService = boatService;

//   }
// }
