import { Injectable } from '@angular/core';
import { Headers, Http, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import { AuthService } from './auth.service';

export class Boat {
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

@Injectable()
export class BoatService {

  private BASE_URL = "https://localhost:44346/";

  constructor(private http: Http, private auth: AuthService) { }

  getBoats(): Observable<Boat[]> {
    let url: string = this.BASE_URL + 'api/boatsapi';
    let token = this.auth.token;
    
    let options = new RequestOptions({headers: new Headers({ 'Authorization': 'Bearer ' + token })});

    let data: Observable<Boat[]> = this.http.get(url, options)
        .map(res => <Boat[]>res.json())
        .do(data => console.log('getBoats:' + JSON.stringify(data)))
        .catch(this.handleError);

    return data;
  }

  private handleError(error: Response): Observable<any> {
    let errorMessage = error.json();
    console.error(errorMessage);
    return Observable.throw(errorMessage.error || 'Server error');
  }
}

// import { Injectable } from '@angular/core';
// import { HttpClient } from '@angular/common/http';
// import { environment } from '../environments/environment';
// import { AuthService } from './auth.service';

// export class Boat {
//   boatId: number;
//   boatName: string;
//   picture: string;
//   lengthInFeet: number;
//   make: string;
//   year: number;
//   recordCreationDate: string;
//   applicationUserId: string;
//   applicationUser: string;
// }

// @Injectable()
// export class BoatService {

//   private boatEndpoint: string;
//   private authService : AuthService;
//   private client: HttpClient;

//   constructor(client: HttpClient, authService : AuthService) {
//     this.boatEndpoint = environment.endpoint + "api/boatsapi/";
//   }

//   public GetBoats(): Promise<Boat[]> {
//     console.log('in get boats')
//     return new Promise<Boat[]>((resolve, reject) => {
//       this.client.get(this.boatEndpoint, this.authService.getAuthHttpOptions()).toPromise().then((resultSets : any) => {
//         resolve(resultSets as (Boat[]));
//       }).catch(r => {
//         reject(r);
//       });
//     });
//   }

// }