import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FetchReservationsComponent } from './fetch-reservations.component';

describe('FetchReservationsComponent', () => {
  let component: FetchReservationsComponent;
  let fixture: ComponentFixture<FetchReservationsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FetchReservationsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FetchReservationsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
