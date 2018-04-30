import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DomainAComponent } from './domain-a.component';

describe('DomainAComponent', () => {
  let component: DomainAComponent;
  let fixture: ComponentFixture<DomainAComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DomainAComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DomainAComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
