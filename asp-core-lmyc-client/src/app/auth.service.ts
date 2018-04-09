import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from './../environments/environment';

@Injectable()
export class AuthService {
  private accountEndpoint: string;
  private _isAuthenticated: boolean;
  private authenticatedCallbacks: Array<{ (key: string): void; }> = [];
  public token: string;

  constructor(private client: HttpClient) {
    this.accountEndpoint = "https://localhost:44346/connect/token/";
  }

  public registerCallback(c: { (key: string): void; }) {
    this.authenticatedCallbacks.push(c);
  }

  public getAuthHttpOptions(): any {
    return {
      headers: new HttpHeaders({
        'Authorization': 'Bearer ' + this.token
      })
    };
  }

  public isAuthenticate() {
    return this._isAuthenticated;
  }

  public Authenticate(username: string, password: string): Promise<string> {

    return new Promise<string>((resolve, reject) => {

      let body = new URLSearchParams();
      body.set('username', username);
      body.set('password', password);
      body.set('grant_type', "password");

      let options = {
        headers: new HttpHeaders().set('Content-Type', 'application/x-www-form-urlencoded')
      };

      this.client.post(this.accountEndpoint, body.toString(), options).toPromise().then( (r : string) => {
        if (r.length == 0)
          return reject("Invalid login credentials.");

        this._isAuthenticated = true;
        this.token = r;

        // TODO: Remove this
        console.log(this.token);

        this.authenticatedCallbacks.forEach(c => {
          c(r);
        });

        resolve(r);

      }).catch(r => {
        reject(r);
      });
    });
  }
}