import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router'; 
import { GanttComponent } from './components/gantt/gantt.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { ProjectsComponent } from './components/projects/projects.component';
import { PersonnelComponent } from './components/personnel/personnel.component';
import { PersonnelAddComponent } from './components/personnel/personnelAdd/personnelAdd.component';

const routes: Routes = [
    { path: 'gantt-component', component: GanttComponent },
    { path: 'inventory-component', component: InventoryComponent },
    { path: 'projects-component', component: ProjectsComponent },
    { path: 'personnel-component', component: PersonnelComponent },
    { path: 'personnelAdd-component', component: PersonnelAddComponent }
]; 


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}