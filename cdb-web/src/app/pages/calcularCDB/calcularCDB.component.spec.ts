/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CalcularCDBComponent } from './calcularCDB.component';

describe('CalcularCDBComponent', () => {
  let component: CalcularCDBComponent;
  let fixture: ComponentFixture<CalcularCDBComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CalcularCDBComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CalcularCDBComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
