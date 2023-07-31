/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { CalcularService } from './calcular.service';

describe('Service: Calcular', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CalcularService]
    });
  });

  it('should ...', inject([CalcularService], (service: CalcularService) => {
    expect(service).toBeTruthy();
  }));
});
