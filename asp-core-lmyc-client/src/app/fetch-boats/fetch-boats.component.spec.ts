import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FetchBoatsComponent } from './fetch-boats.component';

describe('FetchBoatsComponent', () => {
  let component: FetchBoatsComponent;
  let fixture: ComponentFixture<FetchBoatsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FetchBoatsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FetchBoatsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
