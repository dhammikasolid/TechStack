import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DomainBComponent } from './domain-b.component';

describe('DomainBComponent', () => {
  let component: DomainBComponent;
  let fixture: ComponentFixture<DomainBComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DomainBComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DomainBComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
