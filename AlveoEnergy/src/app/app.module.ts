import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { InventoryService }  from './services/inventory.service';
import { GanttComponent } from './components/gantt/gantt.component';
import { PropertiesComponent } from './components/properties/properties.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { AppRoutingModule } from './app.routing.module';
import { ProjectsComponent } from './components/projects/projects.component';
import { PersonnelComponent } from './components/personnel/personnel.component';
import { PersonnelAddComponent } from './components/personnel/personnelAdd/personnelAdd.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from '@angular/material/button';
import { ProjectService } from './services/project.service';
import { TaskService } from './services/task.service';
import { GanttService } from './services/gantt.service';
import { MatTabsModule } from '@angular/material/tabs';
import { MatInputModule, MatPaginatorModule, MatProgressSpinnerModule, MatSortModule, MatTableModule } from '@angular/material';
import { PersonnelService }  from './services/personnel.service';


@NgModule({
  declarations: [
    AppComponent,
    GanttComponent,
    PropertiesComponent,
    InventoryComponent,
    ProjectsComponent,
    PersonnelComponent,
    PersonnelAddComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatListModule,
    MatButtonModule,
    MatTabsModule,
    MatInputModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatProgressSpinnerModule
  ],
  providers: [ 
    InventoryService,
    ProjectService,
    TaskService,
    GanttService ,
    PersonnelService
   ],
  bootstrap: [AppComponent]
})
export class AppModule { }
