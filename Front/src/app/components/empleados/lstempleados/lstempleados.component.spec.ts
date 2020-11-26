import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LstempleadosComponent } from './lstempleados.component';

describe('LstempleadosComponent', () => {
  let component: LstempleadosComponent;
  let fixture: ComponentFixture<LstempleadosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LstempleadosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LstempleadosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
