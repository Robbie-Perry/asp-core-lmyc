import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchBoatsComponent } from './fetch-boats/fetch-boats.component';
import { FetchReservationsComponent } from './fetch-reservations/fetch-reservations.component';
import { LoginComponent } from './login/login.component';
import { BoatService } from './boats.service';
import { AuthService } from './auth.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FetchBoatsComponent,
    FetchReservationsComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'fetch-boats', component: FetchBoatsComponent },
      { path: 'fetch-reservations', component: FetchReservationsComponent },
      { path: 'login', component: LoginComponent },
    ])
  ],
  providers: [
    AuthService,
    BoatService
    ],
  bootstrap: [AppComponent]
})
export class AppModule { }
