import { TestBed, inject } from '@angular/core/testing';

import { BoatsService } from './boats.service';

describe('BoatsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BoatsService]
    });
  });

  it('should be created', inject([BoatsService], (service: BoatsService) => {
    expect(service).toBeTruthy();
  }));
});
